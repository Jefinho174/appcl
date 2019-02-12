function onCheckedItem(e) {
    var row = e.parentElement.parentElement.parentElement;
    if (e.checked) {
        row.classList.add("row-active");
    } else {
        row.classList.remove("row-active");
    }
}


