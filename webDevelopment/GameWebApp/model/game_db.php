<?php
    require_once('database.php');
    
    function get_games() {
        //query the db
        global $db;
        
        // select all person records
        $select_query = 'SELECT g.game_id, g.game_name, g.esrb_rating, g.review_rating, g.platform_id, p.platform
            FROM game g
            LEFT JOIN platform p ON (g.platform_id = p.platform_id)
            ORDER BY esrb_rating, game_name';
        $statement = $db->prepare($select_query);
        $statement->execute();
        $games = $statement->fetchAll();
        $statement->closeCursor();
        
        // return the values
        return $games;
    } // end function
    
    function add_game($game_name, $esrb_rating, $review_rating, $platform_id) {
        //query the db
        global $db;

        // add the person to the database  
        $insert_query = 'INSERT INTO game (game_name, esrb_rating, review_rating, platform_id)
            VALUES (:game_name, :esrb_rating, :review_rating, :platform_id)';
        $statement = $db->prepare($insert_query);
        $statement->bindValue(':game_name', $game_name);
        $statement->bindValue(':esrb_rating', $esrb_rating);
        $statement->bindValue(':review_rating', $review_rating);
        $statement->bindValue(':platform_id', $platform_id);
        $statement->execute();
        $statement->closeCursor();
    } // end function
    
    function update_game($game_id, $game_name, $esrb_rating, $review_rating, $platform_id) {
        //query the db
        global $db;

        // update the person's record in the database 
        $update_query = 'UPDATE game
            SET game_name = :game_name, esrb_rating = :esrb_rating, review_rating = :review_rating, platform_id = :platform_id
            WHERE game_id = :game_id';
        $statement = $db->prepare($update_query);
        $statement->bindValue(':game_id', $game_id);
        $statement->bindValue(':game_name', $game_name);
        $statement->bindValue(':esrb_rating', $esrb_rating);
        $statement->bindValue(':review_rating', $review_rating);
        $statement->bindValue(':platform_id', $platform_id);
        $statement->execute();
        $statement->closeCursor();
    } // end function
    
    function delete_game($game_id) {
        //query the db
        global $db;
        
        // delete the person record from the database
        $delete_query = 'DELETE FROM game
            WHERE game_id = :game_id';
        $statement = $db->prepare($delete_query);
        $statement->bindValue(':game_id', $game_id);
        $statement->execute();
        $statement->closeCursor();
    } // end function

    function search_game($game_name) {
        //query the db
        global $db;
        
        // select all person records
        $searchQuery = 'SELECT g.game_name, g.esrb_rating, g.review_rating, p.platform
            FROM game g
            LEFT JOIN platform p ON (g.platform_id = p.platform_id)
            WHERE game_name = :game_name
            ORDER BY esrb_rating, game_name';
        $statement = $db->prepare($searchQuery);
        $statement->bindValue(':game_name', $game_name);
        $statement->execute();
        $people = $statement->fetchAll();
        $statement->closeCursor();
        
        // return the values
        return $people;
    } // end function
    
    function viewIndividual($p_person_id) {
        //query the db
        global $db;
        
        // delete the person record from the database
        $viewQuery = 'SELECT p.first_name, p.last_name, d.major, d.concentration, j.job_title, j.salary, o.name
                      FROM person p
                        LEFT JOIN degree d ON (p.person_id = d.person_id)
                        LEFT JOIN job j ON (p.person_id = j.person_id)
                        LEFT JOIN organization o ON (j.organization_id = o.organization_id)
                      WHERE p.person_id = :p_person_id';
        $statement = $db->prepare($viewQuery);
        $statement->bindValue(':p_person_id', $p_person_id);
        $statement->execute();
        $person = $statement->fetchAll();
        $statement->closeCursor();
        
        // return the values
        return $person;
    } // end function
?>