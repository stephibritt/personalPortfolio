<?php
    $dsn = 'mysql:host=localhost;dbname=dpjs_database';
    $username = 'dpjs_admin';
    $password = 'password';

    try {
        $db = new PDO($dsn, $username, $password);
    } catch (PDOException $PDOex) {
        $errorMessage = "An error has occurred while connecting to the database: {$PDOex->getMessage()}.";
        exit();
    } catch (Exception $ex) {
        $errorMessage = "An error has occurred while connecting to the database: {$ex->getMessage()}.";
        exit();
    } // end try
?>