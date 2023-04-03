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
            <h1 class="w3-blue-gray w3-center">Manage Person</h1>
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
                        <tr class="w3-light-blue">
                            <th>First Name</th>
                            <th>Last Name</th>
                            <th>Email</th>
                            <th>Phone</th>
                            <th></th>
                            <th></th>
                            <th></th>
                        </tr>
                    </thead>
                    

                    <?php foreach ($people as $person) : ?>
                        <tr>
                            <td><?php echo $person['first_name']; ?></td>
                            <td><?php echo $person['last_name']; ?></td>
                            <td><?php echo $person['email']; ?></td>
                            <td><?php echo $person['phone']; ?></td>
                            <td>
                                <form action="." method="post">
                                    <input type="hidden" name="action" value="showPersonCard">
                                    <input type="hidden" name="person_id" value="<?php echo $person['person_id']; ?>">
                                    <input class="w3-btn w3-light-blue" type="submit" value="View">
                                </form>
                            </td>
                            <td>
                                <form action="." method="post">
                                    <input type="hidden" name="action" value="showUpdateForm">
                                    <input type="hidden" name="person_id" value="<?php echo $person['person_id']; ?>">
                                    <input type="hidden" name="firstName" value="<?php echo $person['first_name']; ?>">
                                    <input type="hidden" name="lastName" value="<?php echo $person['last_name']; ?>">
                                    <input type="hidden" name="email" value="<?php echo $person['email']; ?>">
                                    <input type="hidden" name="phone" value="<?php echo $person['phone']; ?>">
                                    <input class="w3-btn w3-light-blue" type="submit" value="Update">
                                </form>
                            </td>
                            <td>
                                <form action="." method="post">
                                    <input type="hidden" name="action" value="deletePerson">
                                    <input type="hidden" name="person_id" value="<?php echo $person['person_id']; ?>">
                                    <input type="hidden" name="firstName" value="<?php echo $person['first_name']; ?>">
                                    <input type="hidden" name="lastName" value="<?php echo $person['last_name']; ?>">
                                    <input class="w3-btn w3-light-blue" type="submit" value="Delete">
                                </form>
                            </td>
                        </tr>
                    <?php endforeach; ?>
                </table>
            </section>
                    
            <div class="w3-center">
                <a class="w3-blue-gray w3-btn" href="./addPerson.php">Add Person</a>
            </div>
        </main>
            
        <?php include("view/footer.php"); ?>
    </body>
</html>