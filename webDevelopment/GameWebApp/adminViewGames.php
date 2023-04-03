<?php
//    // check for a valid user. If user is not valid
//    if (!isset($_SESSION['admin'])) {
//        // redirect user to login page
//        header("Location: ./manage.php");
//    }
?>

<!DOCTYPE html>
<html lang="en">
    <head>
        <title>Game Web App</title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="w3.css">
    </head>
    
    <body>
        <main>
            <h1 class="w3-red w3-center">Games</h1>
            <?php include("view/nav.php"); ?>
            
            <?php if (!empty($errorMessage)) { ?>
                <div class="w3-panel w3-pale-red">
                    <h3>Error</h3>
                    <?php echo $errorMessage; ?>
                </div>
            <?php } ?>
            
            <?php if (!empty($addedMessage)) { ?>
                <div class="w3-panel w3-green">
                    <h3>Note:</h3>
                    <?php echo $addedMessage; ?>
                </div>
            <?php } ?>
            
            <?php if (!empty($updatedMessage)) { ?>
                <div class="w3-panel w3-green">
                    <h3>Note:</h3>
                    <?php echo $updatedMessage; ?>
                </div>
            <?php } ?>
            
            <?php if (!empty($deletedMessage)) { ?>
                <div class="w3-panel w3-amber">
                    <h3>Note:</h3>
                    <?php echo $deletedMessage; ?>
                </div>
            <?php } ?>
            
            <section class="w3-container w3-margin-top w3-margin-bottom">
                <table class="w3-table-all">
                    <thead>
                        <tr class="w3-pale-red">
                            <th>Game</th>
                            <th>ESRB Rating</th>
                            <th>Consumer Rating</th>
                            <th>Platform</th>
                            <th></th>
                            <th></th>
                        </tr>
                    </thead>
                    

                    <?php foreach ($games as $game) : ?>
                        <tr>
                            <td><?php echo $game['game_name']; ?></td>
                            <td><?php echo $game['esrb_rating']; ?></td>
                            <td><?php echo $game['review_rating']; ?> / 100</td>
                            <td><?php echo $game['platform']; ?></td>
                            <td>
                                <form action="./manage.php" method="post">
                                    <input type="hidden" name="action" value="show_update_form">
                                    <input type="hidden" name="game_id" value="<?php echo $game['game_id']; ?>">
                                    <input type="hidden" name="gameName" value="<?php echo $game['game_name']; ?>">
                                    <input type="hidden" name="esrbRating" value="<?php echo $game['esrb_rating']; ?>">
                                    <input type="hidden" name="reviewRating" value="<?php echo $game['review_rating'] ?>">
                                    <input type="hidden" name="platform_id" value="<?php echo $game['platform_id']; ?>">
                                    <input class="w3-btn w3-dark-gray" type="submit" value="Update">
                                </form>
                            </td>
                            
                            <td>
                                <form action="./manage.php" method="post">
                                    <input type="hidden" name="action" value="delete_game">
                                    <input type="hidden" name="game_id" value="<?php echo $game['game_id']; ?>">
                                    <input type="hidden" name="gameName" value="<?php echo $game['game_name']; ?>">
                                    <input class="w3-btn w3-dark-gray" type="submit" value="Delete">
                                </form>
                            </td>
                    <?php endforeach; ?>
                </table>
            </section>
        </main>
            
        <?php include("view/footer.php"); ?>
    </body>
</html>