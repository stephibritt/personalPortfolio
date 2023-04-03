<div class="w3-bar w3-blue-gray">
    <a class="w3-bar-item w3-button" href=".">Home</a>
    <a class="w3-bar-item w3-button" href="./addPerson.php">Add Person</a>
    
    <div class="w3-dropdown-hover">
        <button class="w3-button w3-cyan">Search</button>
        <div class="w3-dropdown-content w3-bar-block w3-card-4">
            <form action="." method="post">
                <input type="hidden" name="action" value="search">
                <input type="text" name="firstName" class="w3-bar-item w3-input" placeholder="By First Name">
                <input type="text" name="lastName" class="w3-bar-item w3-input w3-border-top" placeholder="By Last Name">
                <input type="email" name="email" class="w3-bar-item w3-input w3-border-top" placeholder="By Email">
                <input class="w3-bar-item w3-btn w3-light-blue w3-center" type="submit" value="Search">
            </form>
        </div>
    </div>
</div>