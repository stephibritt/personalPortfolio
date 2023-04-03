<?php
    session_start();
    require_once('model/game_db.php');
    require_once('model/ticket_db.php');
    
    // get input for action variable from POST array
    $action = filter_input(INPUT_POST, 'action');
    if ($action == NULL) {
        // if action is NULL, check GET array
        $action = filter_input(INPUT_GET, 'action');
        // if action is NULL, set action to view_games
        if ($action == NULL) {
            $action = 'authenticate_user';
        } // end if
    } // end if
    
    // if action = authenticate_user
    if ($action == 'authenticate_user') {
        // if the user has an admin cookie
        $admin = filter_input(INPUT_POST, 'admin');
        if (isset($_SESSION['admin'])) {
            include('./adminMenu.php');
//            header("Location: ./manage.php");
        } else {
            // check for an error message
            $errorMessage = filter_input(INPUT_GET, 'errorMessage');

            // show the authentication page
            include('./adminLogin.php');
        } // end if
        
        // validate the user log in information
    } else if ($action == 'login') {
        // retrieve the user input
        $username = filter_input(INPUT_POST, 'username');
        $username = htmlspecialchars($username);
        
        $password = filter_input(INPUT_POST, 'password');
        $password = htmlspecialchars($password);
    
        // if the username and password are correct
        if ($username == "Admin" && $password == "Pass") {
            // set the admin session to true
            $_SESSION['admin'] = true;
            
            // redirect to the management controller
            header("Location: ./manage.php");
        } else { // if either are incorrect
            // set the error message
            $errorMessage = "Either the username or password was not valid.";
            
            // redirect to the management controller with the error message
            header("Location: ./manage.php?errorMessage=$errorMessage");
        } // end if
    } else if ($action == 'logout') {
        // set admin to false
        $_SESSION[] = [];
        session_destroy();
        
        // set the logout message
        $logoutMessage = "You have successfully been logged out.";
        
        // redirect the user to the home page
        header("Location: .?addedMessage=$logoutMessage");
    } else if ($action == 'show_admin_view') {
        // query the database for games
        $games = get_games();
        
        // check for messages
        $errorMessage = filter_input(INPUT_GET, 'errorMessage');
        $addedMessage = filter_input(INPUT_GET, 'addedMessage');
        $updatedMessage = filter_input(INPUT_GET, 'updatedMessage');
        $deletedMessage = filter_input(INPUT_GET, 'deletedMessage');
        
        // show the view games page
        include('./adminViewGames.php');
        
        // if the admin clicks delete
    } else if ($action == 'delete_game') {
        // retrieve the game id and name
        $game_id = filter_input(INPUT_POST, 'game_id', FILTER_VALIDATE_INT);
        $gameName = filter_input(INPUT_POST, 'gameName');
        
        // if the id has no value
        if ($game_id == NULL || $game_id == FALSE) {
            // show and error message
            $errorMessage = "There was an error deleting the selected file.";
            
            $games = get_games();
            include('./adminViewGames.php');
        } else { // delete the game
            delete_game($game_id);
            
            // confirm the game is deleted
            $deletedMessage = "\"$gameName\" was deleted.";
            $games = get_games();
            include('./adminViewGames.php');
        } // end if
        
        // if the admin clicks update
    } else if ($action == 'show_update_form') {
        // retrieve values for selected row
        $game_id = filter_input(INPUT_POST, 'game_id', FILTER_VALIDATE_INT);
        $gameName = filter_input(INPUT_POST, 'gameName');
        $esrbRating = filter_input(INPUT_POST, 'esrbRating');
        $reviewRating = filter_input(INPUT_POST, 'reviewRating', FILTER_VALIDATE_EMAIL);
        $platform_id = filter_input(INPUT_POST, 'platform_id');
        
        // show the update form
        include('./updateGame.php');
        
        // if the user submits the update
    } else if ($action == 'update_game') {
        // retrieve the values from the form
        $game_id = filter_input(INPUT_POST, 'game_id', FILTER_VALIDATE_INT);
        $gameName = htmlspecialchars(filter_input(INPUT_POST, 'gameName'));
        $esrbRating = htmlspecialchars(filter_input(INPUT_POST, 'esrbRating'));
        $reviewRating = filter_input(INPUT_POST, 'reviewRating');
        $platform_id = filter_input(INPUT_POST, 'platform_id');
        
        // if the variables have no value
        if ($game_id == NULL || $game_id == FALSE || $gameName == NULL || $gameName == FALSE) {
            // set the error message and show the admin view page
            $errorMessage = "A file cannot be updated without valid information.";
            $games = get_games();
            include('./adminViewGames.php');
        } else { 
            update_game($game_id, $gameName, $esrbRating, $reviewRating, $platform_id);
            
            $updatedMessage = "\"$gameName\" was updated.";
            $games = get_games();
            include('./adminViewGames.php');
        } // end if
        
        // if the admin clicks add record
    } else if ($action == 'show_add_form') {
        include('./addGame.php');
    } else if ($action == 'add_game') {
        // retrieve the values from the form
//        $game_id = filter_input(INPUT_POST, 'game_id', FILTER_VALIDATE_INT);
        $gameName = htmlspecialchars(filter_input(INPUT_POST, 'gameName'));
        $esrbRating = htmlspecialchars(filter_input(INPUT_POST, 'esrbRating'));
        $reviewRating = filter_input(INPUT_POST, 'reviewRating');
        $platform_id = filter_input(INPUT_POST, 'platform_id');
        
        // if the variables have no value
        if ($gameName == NULL || $gameName == FALSE) {
            // set the error message and show the admin view page
            $errorMessage = "A file cannot be updated without valid information.";
            $games = get_games();
            include('./adminViewGames.php');
        } else { 
            add_game($gameName, $esrbRating, $reviewRating, $platform_id);
            
            $addedMessage = "\"$gameName\" was added.";
            $games = get_games();
            include('./adminViewGames.php');
        } // end if
    }
?>