<div class="w3-bar w3-deep-orange">
    <a class="w3-bar-item w3-button" href=".">Home</a>
    <a class="w3-bar-item w3-button" href=".?action=view_ticket">Ticket</a>
    <a class="w3-bar-item w3-button" href="./manage.php">Management Portal</a>
    
    <div class="w3-dropdown-hover w3-margin-left">
        <button class="w3-button w3-amber">Search</button>
        <div class="w3-dropdown-content w3-bar-block w3-card-4">
            <form action="." method="post">
                <input type="hidden" name="action" value="search">
                <input type="text" name="game_name" class="w3-bar-item w3-input w3-right" placeholder="By Game Name">
                <input class="w3-bar-item w3-btn w3-amber w3-center" type="submit" value="Search">
            </form>
        </div>
    </div>
</div>