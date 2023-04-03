<!DOCTYPE html>
<html lang="en">
    <head>
        <title>Chapter 6 Lab: Manage Person</title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="w3.css">
    </head>
    
    <body>
        <main>
            <h1 class="w3-blue-gray w3-center">Person Card</h1>
            <?php include("view/nav.php"); ?>
            <section class="w3-container w3-margin-top w3-margin-bottom">
                <?php foreach ($person as $person) : ?>
                    <div class="w3-card w3-padding">
                        <h3 class="w3-text-blue"><b>Person</b></h3>
                        <p><b>First Name</b>: <?php echo $person['first_name'] ; ?> &nbsp;  &nbsp; &nbsp; <b>Last Name</b>: <?php echo $person['last_name']; ?></p>
                        <hr>
                        <h3 class="w3-text-amber"><b>Degree</b></h3>   
                        <p><b>Major</b>: <?php echo $person['major']; ?> &nbsp;  &nbsp; &nbsp; <b>Concentration</b>: <?php echo $person['concentration']; ?></p>
                        <hr>
                        <h3 class="w3-text-green"><b>Job Details</b></h3>    
                        <p><b>Organization</b>: <?php echo $person['name']; ?> &nbsp;  &nbsp; &nbsp; <b>Job Title</b>: <?php echo $person['job_title']; ?> &nbsp;  &nbsp; &nbsp; <b>Salary</b>: <?php echo $person['salary']; ?></p>
                    </div>
                <?php endforeach; ?>
            </section>                    
        </main>   
        <?php include("view/footer.php"); ?>
    </body>
</html>