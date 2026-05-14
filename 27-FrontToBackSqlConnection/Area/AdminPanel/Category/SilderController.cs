[HttpPost]
public async Task<IActionResult> Create(Slider slider)
{
    if (slider.Photo == null)
    {
        ModelState.AddModelError("Photo", "Please select a file!");
        return View();
    }

    
    if (!slider.Photo.ContentType.Contains("image/"))
    {
        ModelState.AddModelError("Photo", "File type is incorrect!");
        return View();
    }

 
    if (slider.Photo.Length > 2 * 1024 * 1024)
    {
        ModelState.AddModelError("Photo", "File size must be less than 2 MB!");
        return View();
    }

    
    string fileName = Guid.NewGuid().ToString() + slider.Photo.FileName;

    string path = Path.Combine(
        _env.WebRootPath,
        "assets",
        "images",
        "website-images",
        fileName
    );

    using (FileStream stream = new FileStream(path, FileMode.Create))
    {
        await slider.Photo.CopyToAsync(stream);
    }

    /
    slider.Image = fileName;

    await _context.Sliders.AddAsync(slider);
    await _context.SaveChangesAsync();

    return RedirectToAction(nameof(Index));



    SliderUpdateVM sliderUpdateVM = new()
    {
        Title = slider.Title,
        Subtitle = slider.Subtitle,
        Description = slider.Description,
        Order = slider.Order,
        Image = slider.Image,
    };

    return View(sliderUpdateVM);


    public async Task<IActionResult> Detail(int id)
{
    var slider = await _context.Sliders.FirstOrDefaultAsync(m => m.Id == id);

    if (slider == null)
    {
        return NotFound();
    }

    return View(slider);
}
}
