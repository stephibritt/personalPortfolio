<?php
    require_once('model/game_db.php');
    require_once('model/ticket_db.php');
    
    // get input for action variable from POST array
    $action = filter_input(INPUT_POST, 'action');
    if ($action == NULL) {
        // if action is NULL, check GET array
        $action = filter_input(INPUT_GET, 'action');
        // if action is NULL, set action to view_games
        if ($action == NULL) {
            $action = 'view_games';
        } // end if
    } // end if

    // if the home (view) page is requested
    if ($action == 'view_games') {
        // query the database for games
        $games = get_games();
        
        // check for messages
        $errorMessage = filter_input(INPUT_GET, 'errorMessage');
        $addedMessage = filter_input(INPUT_GET, 'addedMessage');
        $updatedMessage = filter_input(INPUT_GET, 'updatedMessage');
        $deletedMessage = filter_input(INPUT_GET, 'deletedMessage');
        
        // show the view games page
        include('./viewGames.php');
        
        // if the search function is used
    } else if ($action == 'search') {
        // retrieve the game to search by
        $game_name = htmlspecialchars(filter_input(INPUT_POST, 'game_name'));
        
        // if the game name is not blank
        if (($game_name != NULL || $game_name != FALSE )) {
            $games = search_game($game_name);
            
            include('./viewGames.php');
        } else { // if game name was left blank
            // set the error message
            $errorMessage = "Search cannot be left blank.";
            
            // send a new request to the server for the main page
            header("Location: .?errorMessage=$errorMessage");
        } // end if
        
        // if the user clicks 'Ticket' in the nav
    } else if ($action == 'view_ticket') {
        // query the database for the tickets
        $tickets = get_ticket();
        
        // check for message
        $addedMessage = filter_input(INPUT_GET, 'addedMessage');

        // show the ticket page
        include('./viewTicket.php');
        
        // if the user attempts to add a new ticket
    } else if ($action == 'add_ticket') {
        // retrieve the values for the following variables
        $gameName = htmlspecialchars(filter_input(INPUT_POST, 'game_name'));
        $esrbRating = htmlspecialchars(filter_input(INPUT_POST, 'esrb_rating'));
        $genre = filter_input(INPUT_POST, 'genre');
        $platform = filter_input(INPUT_POST, 'platform');
        
        // if the variables are blank
        if ($gameName == NULL || $esrbRating== NULL || $genre == NULL || $platform == NULL) {
            $errorMessage = "A ticket could not be added.";
            include('./viewTicket.php');
        } else { 
            // add the ticket to the database
            add_ticket($gameName, $esrbRating, $genre, $platform);
            
            // define the message confirming the added ticket
            $addedMessage = "The ticket for \"$gameName\" was successfully added.";
            
            // query the database for tickets
            $tickets = get_ticket();
            
            // show the ticket page
            include('./viewTicket.php');
        } // end if
        
        // if the user clicks 'View' on a ticket item
    } else if ($action == 'show_ticket_card') {
        // retrieve the ticket id
        $ticket_id = filter_input(INPUT_POST, 'ticket_id', FILTER_VALIDATE_INT);
        
        // select the specific ticket by ID
        $ticket = view_ticket_card($ticket_id);
        
        // show the ticket page
        include('./ticketCard.php');
    } // end if
?>