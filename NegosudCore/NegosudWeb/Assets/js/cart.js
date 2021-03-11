let cartJson = JSON.parse(localStorage.getItem("cart"));

if (cartJson) {
    document.getElementById("cartCounter").innerHTML = cartJson.length;
} else {
    document.getElementById("cartCounter").innerHTML = 0;
}