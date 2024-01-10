<?php



// Kickstart the framework
//equire_once 'vendor/autoload.php';
require_once("middleware/Auth.php");
$f3 = require('lib/base.php');


$f3->set('DEBUG', 1);

if ((float)PCRE_VERSION < 8.0)

	trigger_error('PCRE version is out of date');



// Load configuration
$f3->set('CORS.origin', '*');

$f3->config('config.ini');

$f3->config('routes.ini');




$f3->set(

	'DB',

	new \DB\SQL('mysql:host=' . $f3->get('database.host')  . ';port=3306;dbname=' . $f3->get('database.dbname'), $f3->get('database.user'), $f3->get('database.pass')),

	$options = array(

		\PDO::ATTR_ERRMODE => \PDO::ERRMODE_EXCEPTION, // generic attribute

		\PDO::ATTR_PERSISTENT => TRUE,  // we want to use persistent connections

		\PDO::MYSQL_ATTR_COMPRESS => TRUE, // MySQL-specific attribute

	)

);



$f3->route('POST /ValidaUser', 'Dav_Ctrol->ValidaUser');



$f3->route('GET /fecha', function ($f3) {
	$geo = \Web\Geo::instance();
	// $geo = \Web\Geo::instance();
	// var_dump($geo->location());
	echo json_encode(var_dump($f3->get('ALIAS')));
});

$f3->route('GET /fechaip', function ($f3) {
	$geo = \Web\Geo::instance();
	echo json_encode(var_dump($geo->location( $ip = NULL)));
});

$f3->route('GET /fechaip1', function ($f3) {
	$geo = \Web\Geo::instance();
	echo json_encode(var_dump($geo->location()["country_code"]));
});

$f3->route('GET /fechahora', function ($f3) {
	$mifecha = date('Y-m-d H:i:s');
	$NuevaFecha = strtotime('-4 hour', strtotime($mifecha));
	$NuevaFecha = date ( 'Y-m-d H:i:s' , $NuevaFecha); 
	echo json_encode(var_dump($NuevaFecha));
});

$f3->route('GET /fechahora1', function ($f3) {	
	$NuevaFecha = date ( 'Y-m-d H:i:s' , strtotime('-4 hour', strtotime(date('Y-m-d H:i:s')))); 
	echo json_encode(var_dump($NuevaFecha));
});



$f3->route('GET /api/prueba', function ($f3) {

	// echo "<pre>";

	// print_r($f3->get('DB'));

	// echo "</pre>";

	//echo json_encode('hola david todo ok');
	$usuario  = 'eduardo';
	$password = '123456';

	$token = Auth::SignIn([
		'id' => 1,
		'name' => 'Eduardo'
	]);
	echo $token;
	print_r(Auth::GetData($token));
});









// $f3->route('GET /prueba-1', function ($f3) {



// 	echo "<pre>";

// 	print_r($f3->get('POST'));

// 	print_r($f3->get('GET'));

// 	print_r($f3->get('REQUEST'));

// 	print_r($f3->get('SERVER'));

// 	 print_r($_SERVER);

// 	echo "</pre>";

// });







$f3->route(

	'GET /',

	function ($f3) {

		$classes = array(

			'Base' =>

			array(

				'hash',

				'json',

				'session',

				'mbstring'

			),

			'Cache' =>

			array(

				'apc',

				'apcu',

				'memcache',

				'memcached',

				'redis',

				'wincache',

				'xcache'

			),

			'DB\SQL' =>

			array(

				'pdo',

				'pdo_dblib',

				'pdo_mssql',

				'pdo_mysql',

				'pdo_odbc',

				'pdo_pgsql',

				'pdo_sqlite',

				'pdo_sqlsrv'

			),

			'DB\Jig' =>

			array('json'),

			'DB\Mongo' =>

			array(

				'json',

				'mongo'

			),

			'Auth' =>

			array('ldap', 'pdo'),

			'Bcrypt' =>

			array(

				'openssl'

			),

			'Image' =>

			array('gd'),

			'Lexicon' =>

			array('iconv'),

			'SMTP' =>

			array('openssl'),

			'Web' =>

			array('curl', 'openssl', 'simplexml'),

			'Web\Geo' =>

			array('geoip', 'json'),

			'Web\OpenID' =>

			array('json', 'simplexml'),

			'Web\OAuth2' =>

			array('json'),

			'Web\Pingback' =>

			array('dom', 'xmlrpc'),

			'CLI\WS' =>

			array('pcntl')

		);

		$f3->set('classes', $classes);

		$f3->set('content', 'welcome.htm');

		echo View::instance()->render('layout.htm');
	}

);



$f3->route(

	'GET /userref',

	function ($f3) {

		$f3->set('content', 'userref.htm');

		echo View::instance()->render('layout.htm');
	}

);



$f3->run();
