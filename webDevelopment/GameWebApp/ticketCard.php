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
            <h1 class="w3-red w3-center">Ticket Card</h1>
            <?php include("view/nav.php"); ?>
            <section class="w3-container w3-margin-top w3-margin-bottom">
                <?php foreach ($ticket as $ticket) : ?>
                    <div class="w3-card w3-padding">
                        <h3 class="w3-text-red"><b><?php echo $ticket['game_name']?>'s Ticket</b></h3>
                        <p><b>ESRB Rating</b>: <?php echo $ticket['esrb_rating']; ?></p>
                        <hr>  
                        <p><b>Genre</b>: <?php echo $ticket['genre']; ?></p>
                        <hr>
                        <p><b>Platform</b>: <?php echo $ticket['platform']; ?></p>
                    </div>
                <?php endforeach; ?>
            </section>                    
        </main>   
        <?php include("view/footer.php"); ?>
    </body>
</html>