<?php
session_start();

require_once("admin_util.php");

if (isset($_SESSION['login_succeed']) && $_SESSION['login_succeed'] === true)
{
	if (isset($_GET['t']))
	{
		switch ($_GET['t'])
		{
			case '1':
				$output = "";
				if (isset($_POST['type_name']) && isset($_POST['class_name']) && isset($_POST['price']))
					add_new_gift($_POST['type_name'], $_POST['class_name'], $_POST['price']);
				$output .= "<div style=\"border: dashed 1px; padding: 10px;\">\n";
				$output .= "<form id=\"add_gift\">\n";
				$output .= "Gift Name: <input type=\"text\" name=\"type_name\" /><br/>\n";
				$output .= "Class Name: <input type=\"text\" name=\"class_name\" />(this is the [add name you use in RunUO admin account)<br/>\n";
				$output .= "Price: <input type=\"text\" name=\"price\" /><br/>\n";
				$output .= "<input type=\"button\" value=\"Add\" onclick=\"submitForm('add_gift','admin_ops.php?t=1')\"/>\n";
				$output .= "</form></div>\n";
				
				$output .= "<br/><strong>Donation Gift Types in Database:</strong><br/>\n";
				$output .= query_to_table("SELECT * FROM gift_type");
			break;
			
			case '2':
				$output = "<strong>Transaction records:</strong><br/>\n";
				$output .= query_to_table("SELECT * FROM paypal_transaction ORDER BY payment_date DESC");
				$output .= "<br/>\n";
				$output .= "<strong>Processed transactions:</strong><br/>\n";
				$output .= query_to_table("SELECT paypal_transaction.*, paypal_processed_txn.create_time FROM paypal_processed_txn INNER JOIN paypal_transaction ON paypal_processed_txn.txn_id=paypal_transaction.txn_id ORDER BY create_time DESC");
				$output .= "<br/>\n";
				$output .= "<strong>Not Yet Redeemed Gifts:</strong><br/>\n";
				$output .= query_to_table("SELECT id, type_name, account_name, paypal_txn_id, FROM_UNIXTIME(donate_time) AS donate_time FROM redeemable_gift INNER JOIN gift_type ON redeemable_gift.type_id=gift_type.type_id ORDER BY donate_time DESC");
				$output .= "<br/>\n";
				$output .= "<strong>Redeemed Gifts:</strong><br/>\n";
				$output .= query_to_table("SELECT id, type_name, account_name, paypal_txn_id, FROM_UNIXTIME(donate_time) AS donate_date, FROM_UNIXTIME(redeem_time) AS redeem_date, serial FROM redeemed_gift INNER JOIN gift_type ON redeemed_gift.type_id=gift_type.type_id ORDER BY redeem_date DESC");
			break;
			
			case '3':
				require_once("config.php");
				$output = "<strong>Logs:</strong><br/>\n";
				$output .= "<div style=\"border: dashed 1px; padding: 10px;\">\n";
				if (file_exists($log))
					$temp = file_get_contents($log);
				$output .= nl2br($temp);
				$output .= "</div>\n";
				$output .= "<br/>\n<br/>\n<strong>Error Logs:</strong><br/>\n";
				$output .= "<div style=\"border: dashed 1px; padding: 10px;\">\n";
				$temp = "";
				if (file_exists($error_log))
					$temp = file_get_contents($error_log);
				$output .= nl2br($temp);
				$output .= "</div>\n";
				$output .= "<br/>\n<br/>\n<strong>Invalid Transaction Logs:</strong><br/>\n";
				$output .= "<div style=\"border: dashed 1px; padding: 10px;\">\n";
				$temp = "";
				if (file_exists($invalid_txn_log))
					$temp = file_get_contents($invalid_txn_log);
				$output .= nl2br($temp);
				$output .= "</div>\n";
				$output .= "<br/>\n<br/>\n<strong>All Received Requests From PayPal IPN:</strong><br/>\n";
				$output .= "<div style=\"border: dashed 1px; padding: 10px;\">\n";
				$temp = "";
				if (file_exists($request_log))
					$temp = file_get_contents($request_log);
				$output .= nl2br($temp);
				$output .= "</div>\n";
			break;
			
			case '4':
				if (isset($_POST['id']))
					remove_gift($_POST['id']);
				$output = "<div style=\"border: dashed 1px; padding: 10px;\">\n";
				$output .= "<form id=\"remove_gift\">\n";
				$output .= "Gift Type ID: <input type=\"text\" name=\"id\" /><br/>\n";
				$output .= "<input type=\"button\" value=\"Remove\" onclick=\"submitForm('remove_gift','admin_ops.php?t=4')\"/>\n";
				$output .= "</form></div>\n";
				
				$output .= "<br/><strong>Donation Gift Types in Database:</strong><br/>\n";
				$output .= query_to_table("SELECT * FROM gift_type");
			break;
			
			case '5':
				$output = get_gift_code_table();
			break;
			
			case '6':
				if (isset($_POST['type_id']) && isset($_POST['account_name']) && isset($_POST['quantity']))
					manual_add_gift($_POST['type_id'], $_POST['account_name'], $_POST['quantity']);
				
				$gift_types = get_gift_types();
				$output = "";
				$output .= "<div style=\"border: dashed 1px; padding: 10px;\">\n";
				$output .= "<form id=\"add_gift_to_account\">\n";
				$output .= "Gift Type: <select name=\"type_id\">\n";
				foreach ($gift_types as $row)
				{
					$id = $row['type_id'];
					$type_name = $row['type_name'];
					$output .= "<option value=\"$id\">$type_name</option>\n";
				}
				$output .= "</select><br/>\n";
				$output .= "Account Name: <input type=\"text\" name=\"account_name\" /><br/>\n";
				$output .= "Quantity: <input type=\"text\" name=\"quantity\" /><br/>\n";
				$output .= "<input type=\"button\" value=\"Add\" onclick=\"submitForm('add_gift_to_account','admin_ops.php?t=6')\"/>\n";
				$output .= "</form></div>\n";
				
				$output .= "<br/><strong>Not Yet Redeemed Gifts:</strong><br/>\n";
				$output .= query_to_table("SELECT id, type_name, account_name, paypal_txn_id, FROM_UNIXTIME(donate_time) AS donate_time FROM redeemable_gift INNER JOIN gift_type ON redeemable_gift.type_id=gift_type.type_id ORDER BY donate_time DESC");
			break;
		}
	}
}

echo($output);
?>