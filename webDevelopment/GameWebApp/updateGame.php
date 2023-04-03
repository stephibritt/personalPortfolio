<?php
    //get variables
    $game_id = filter_input(INPUT_POST, 'game_id', FILTER_VALIDATE_INT);
    $gameName = filter_input(INPUT_POST, 'gameName');
    $esrbRating = filter_input(INPUT_POST, 'esrbRating');
    $reviewRating = filter_input(INPUT_POST, 'reviewRating');
    $platform_id = filter_input(INPUT_POST, 'platform_id');
    
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
            <h1 class="w3-red w3-center">Update Game</h1>
        </header>
        <?php include("./view/nav.php"); ?>
        
        <main>
            <p>Use this page to update a game record in the database.</p>
            
                <form class="w3-container w3-margin" action="./manage.php" method="post">
                    <input type="hidden" name="action" value="update_game">
                    <input type="hidden" name="game_id" value="<?php echo $game_id; ?>">
                    <input class="w3-input w3-border w3-round" type="text" placeholder="Game Name" name="gameName" value="<?php echo htmlspecialchars($gameName); ?>" required autofocus>
                    <br>
                    <input class="w3-input w3-border w3-round" type="text" placeholder="ESRB Rating (E, E10+, T, M, X, N/A)" name="esrbRating" value="<?php echo htmlspecialchars($esrbRating); ?>" required>
                    <br>
                    <input class="w3-input w3-border w3-round" type="text" placeholder="Consumer Rating" name="reviewRating" value="<?php echo htmlspecialchars($reviewRating); ?>" required>
                    <br>
                    <input class="w3-input w3-border w3-round" type="text" placeholder="Platform ID" name="platform_id" value="<?php echo htmlspecialchars($platform_id); ?>" required>
                    <br>
                
                    <div class="w3-center">
                        <input class="w3-btn w3-gray" type="submit" value="Update">
                    </div>
                </form>
        </main>
            
        <?php include("./view/footer.php"); ?>
    </body>
</html>