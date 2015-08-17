<?php

/*** MYSQL DATABASE SETTINGS ***/

//IP or domain name of your MySQL host
define("DB_HOST","UnmixedUO.db.12051117.hostedresource.com");

//The database name which we are using
define("DB_NAME","UnmixedUO");

//user that can access to your MySQL database, be careful that this account should be CREATE TABLE privilege
define("DB_USER","UnmixedUO");

//password
define("DB_PASS","Bigbang8!");




/*** ADMIN PANEL SETTINGS ***/

//administrator login name
define("ADMIN_USER","zycron");

//password
define("ADMIN_PASS","Bigbang81");



/*** PAYPAL IPN SETTINGS ***/

//your email account for PayPal
$my_email = 'scrubtasticx@live.com';
//your PayPal merchant ID
$my_merchant_id = 'ASQAH54NEPGCG';
//The currency of donation
$local_currency = "USD";
//IPN handler URL, modify the domain name and the directory path to suit your site
$ipn_handler_url = "http://glaze-tech.net/donations/donation_paypal_ipn_handler.php";

// do not edit below URL if you don't know what it is doing
$paypal_ipn_resp_addr = 'ssl://www.paypal.com';
//$paypal_ipn_resp_addr = 'ssl://www.sandbox.paypal.com';	/** for testing purpose **/

//logs file location of your webserver
$request_log = $_SERVER['DOCUMENT_ROOT'].'/logs/paypal_request.log';
$log = $_SERVER['DOCUMENT_ROOT'].'/logs/donation_paypal.log';
$error_log = $_SERVER['DOCUMENT_ROOT'].'/logs/donation_paypal_error.log';
$invalid_txn_log = $_SERVER['DOCUMENT_ROOT'].'/logs/donation_paypal_invalid_txn.log';

?>
