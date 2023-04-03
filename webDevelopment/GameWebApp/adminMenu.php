<?php
    // get input for action variable from POST array
//    $username = filter_input(INPUT_POST, 'action');
//    $password = filter_input(INPUT_POST, 'action');
            
//    if ($action == NULL) {
//        // if action is NULL, check GET array
//        $action = filter_input(INPUT_GET, 'action');
//        // if action is NULL, set action to view_games
//        if ($action == NULL) {
//            $action = 'authenticate_user';
//        } // end if
//    } // end if
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
                    <?php echo $errorMessage; ?>
                </div>
            <?php } ?>
            
            <div class="w3-card-2 w3-margin">
                <header class="w3-container w3-dark-gray w3-center">
                    <h2>Management Portal</h2>
                </header>
                
                <div class="w3-container w3-center">
                    <a class="w3-btn w3-gray w3-margin" href="./manage.php?action=show_admin_view">Manage Records</a>
                    <a class="w3-btn w3-gray w3-margin" href="./manage.php?action=show_add_form">Add Record</a>
                    <!--<a class="w3-btn w3-gray w3-margin" href="./manage.php?action=logout">Manage Tickets</a>-->
                    <a class="w3-btn w3-gray w3-margin" href="./manage.php?action=logout">Log Out</a>
                </div>
            </div>
        </main>
            
        <?php include("view/footer.php"); ?>
    </body>
</html>