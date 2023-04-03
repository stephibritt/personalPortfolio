<?php
    if (!isset($gameName)) {
        $gameName = "";
    } // end if
    
    if (!isset($esrbRating)) {
        $esrbRating = "";
    } // end if
    
    if (!isset($genre)) {
        $genre = "";
    } // end if
    
    if (!isset($platform)) {
        $platform = "";
    } // end if
?>

<!DOCTYPE html>
<html lang="en">
    <head>
        <title>Game Web App</title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="./w3.css">
    </head>
    
    <body>
        <header>
            <h1 class="w3-red w3-center">Add Ticket</h1>
        </header>
        <?php include("view/nav.php"); ?>
        
        <main>
            <div class="w3-center w3-container w3-margin w3-dark-gray">
                <h3>This Page Allows You To Add A Ticket For A Game To Be Added To The Database</h3>
            </div>
                <form class="w3-container w3-margin" action="." method="post">
                    <input type="hidden" name="action" value="add_ticket">
                    <input class="w3-input w3-border w3-round" type="text" placeholder="Game Name" name="game_name" value="<?php echo htmlspecialchars($gameName); ?>" required autofocus>
                    <br>
                    <input class="w3-input w3-border w3-round" type="text" placeholder="ESRB Rating (E, E10+, T, M, X, N/A)" name="esrb_rating" value="<?php echo htmlspecialchars($esrbRating); ?>" required>
                    <br>
                    <input class="w3-input w3-border w3-round" type="text" placeholder="Genre (genre/genre)" name="genre" value="<?php echo htmlspecialchars($genre); ?>" required>
                    <br>
                    <input class="w3-input w3-border w3-round" type="text" placeholder="Platform" name="platform" value="<?php echo htmlspecialchars($platform); ?>" required>
                    <br>
                
                    <div class="w3-center">
                        <input class="w3-btn w3-dark-grey" type="submit" value="Add">
                    </div>
                </form>
        </main>
            
        <?php include("./view/footer.php"); ?>
    </body>
</html>