const card = document.createElement("div");
app.appendChild(card);

Object.assign(card.style, {
  width: "350px",
  borderRadius: "12px",
  overflow: "hidden",
  boxShadow: "0 4px 10px rgba(0,0,0,0.1)",
  fontFamily: "Arial",
  background: "#fff",
  margin: "50px auto"
});

const imgBox = document.createElement("div");
imgBox.style.position = "relative";

const img = document.createElement("div");
Object.assign(img.style, {
  height: "200px",
  backgroundImage: "url('https://images.unsplash.com/photo-1568605114967-8130f3a36994')",
  backgroundSize: "cover",
  backgroundPosition: "center"
});


const heart = document.createElement("i");
heart.className = "fa-regular fa-heart";

Object.assign(heart.style, {
  position: "absolute",
  top: "10px",
  right: "10px",
  fontSize: "22px",
  color: "white",
  cursor: "pointer"
});

heart.onclick = () => {
  if (heart.classList.contains("fa-regular")) {
    heart.classList.remove("fa-regular");
    heart.classList.add("fa-solid");
    heart.style.color = "red";
  } else {
    heart.classList.remove("fa-solid");
    heart.classList.add("fa-regular");
    heart.style.color = "white";
  }
};

imgBox.append(img, heart);
card.appendChild(imgBox);


const content = document.createElement("div");
content.style.padding = "15px";


const type = document.createElement("div");
type.innerText = "DETACHED HOUSE • 5Y OLD";
type.style.color = "#777";


const price = document.createElement("div");
price.innerText = "$750,000";
price.style.fontSize = "24px";
price.style.fontWeight = "bold";


const address = document.createElement("div");
address.innerText = "742 Evergreen Terrace";
address.style.color = "#555";

const info = document.createElement("div");
Object.assign(info.style, {
  display: "flex",
  justifyContent: "space-between",
  margin: "10px 0"
});


const bed = document.createElement("div");
bed.innerHTML = '<i class="fa-solid fa-bed"></i> 3 Bedrooms';


const bath = document.createElement("div");
bath.innerHTML = '<i class="fa-solid fa-bath"></i> 2 Bathrooms';

info.append(bed, bath);


const realtor = document.createElement("div");
Object.assign(realtor.style, {
  display: "flex",
  alignItems: "center",
  marginTop: "15px"
});

const avatar = document.createElement("div");
Object.assign(avatar.style, {
  width: "40px",
  height: "40px",
  borderRadius: "50%",
  backgroundImage: "url('https://randomuser.me/api/portraits/women/44.jpg')",
  backgroundSize: "cover",
  marginRight: "10px"
});

const infoBox = document.createElement("div");

const name = document.createElement("div");
name.innerText = "Tiffany Heffner";
name.style.fontWeight = "bold";

const phone = document.createElement("div");
phone.innerText = "(555) 555-4321";
phone.style.color = "#777";

infoBox.append(name, phone);
realtor.append(avatar, infoBox);


content.append(type, price, address, info, realtor);
card.appendChild(content);