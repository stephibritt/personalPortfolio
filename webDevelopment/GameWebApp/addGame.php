<?php
    if (!isset($gameName)) {
        $gameName = "";
    } // end if
    
    if (!isset($esrbRating)) {
        $esrbRating = "";
    } // end if
    
    if (!isset($reviewRating)) {
        $reviewRating = "";
    } // end if
    
    if (!isset($platform_id)) {
        $platform_id = "";
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
            <h1 class="w3-red w3-center">Add Game</h1>
        </header>
        <?php include("view/nav.php"); ?>
        
        <main>
            <p>Use this page to add a game record to the database.</p>
            
                <form class="w3-container w3-margin" action="./manage.php" method="post">
                    <input type="hidden" name="action" value="add_game">
                    <input class="w3-input w3-border w3-round" type="text" placeholder="Game Name" name="gameName" value="<?php echo htmlspecialchars($gameName); ?>" required autofocus>
                    <br>
                    <input class="w3-input w3-border w3-round" type="text" placeholder="ESRB Rating (E, E10+, T, M, X, N/A)" name="esrbRating" value="<?php echo htmlspecialchars($esrbRating); ?>" required>
                    <br>
                    <input class="w3-input w3-border w3-round" type="text" placeholder="Consumer Rating" name="reviewRating" value="<?php echo htmlspecialchars($reviewRating); ?>" required>
                    <br>
                    <input class="w3-input w3-border w3-round" type="text" placeholder="Platform ID" name="platform_id" value="<?php echo htmlspecialchars($platform_id); ?>" required>
                    <br>
                
                    <div class="w3-center">
                        <input class="w3-btn w3-gray" type="submit" value="Add">
                    </div>
                </form>
        </main>
            
        <?php include("./view/footer.php"); ?>
    </body>
</html>