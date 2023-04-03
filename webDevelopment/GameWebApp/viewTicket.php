
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
            <h1 class="w3-red w3-center">Tickets</h1>
            <?php include("view/nav.php"); ?>
            
            <?php
            
            if (!empty($errorMessage)) { ?>
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
            
            <div class="w3-center">
                <a class="w3-dark-grey w3-btn w3-margin-top" href="./addTicket.php">Add Ticket</a>
            </div>
            
            <section class="w3-container w3-margin-top w3-margin-bottom">
                <table class="w3-table-all">
                    <thead>
                        <tr class="w3-pale-red">
                            <th>Game</th>
                            <th>ESRB Rating</th>
                            <th>Genre</th>
                            <th>Platform</th>
                            <th></th>
                        </tr>
                    </thead>
                    

                    <?php foreach ($tickets as $ticket) : ?>
                        <tr>
                            <td><?php echo $ticket['game_name']; ?></td>
                            <td><?php echo $ticket['esrb_rating']; ?></td>
                            <td><?php echo $ticket['genre']; ?></td>
                            <td><?php echo $ticket['platform']; ?></td>
                            <td>
                                <form action="." method="post">
                                    <input type="hidden" name="action" value="show_ticket_card">
                                    <input type="hidden" name="ticket_id" value="<?php echo $ticket['ticket_id']; ?>">
                                    <input class="w3-btn w3-dark-gray" type="submit" value="View">
                                </form>
                            </td>
                        </tr>
                    <?php endforeach; ?>
                </table>
            </section>
                    
            <div class="w3-center">
                <a class="w3-dark-grey w3-btn" href="./addTicket.php">Add Ticket</a>
            </div>
        </main>
            
        <?php include("view/footer.php"); ?>
    </body>
</html>