<?php
/**
 * The base configuration for WordPress
 *
 * The wp-config.php creation script uses this file during the installation.
 * You don't have to use the website, you can copy this file to "wp-config.php"
 * and fill in the values.
 *
 * This file contains the following configurations:
 *
 * * Database settings
 * * Secret keys
 * * Database table prefix
 * * ABSPATH
 *
 * @link https://developer.wordpress.org/advanced-administration/wordpress/wp-config/
 *
 * @package WordPress
 */

// ** Database settings - You can get this info from your web host ** //
/** The name of the database for WordPress */
define( 'DB_NAME', 'shangina' );

/** Database username */
define( 'DB_USER', 'root' );

/** Database password */
define( 'DB_PASSWORD', '' );

/** Database hostname */
define( 'DB_HOST', 'localhost' );

/** Database charset to use in creating database tables. */
define( 'DB_CHARSET', 'utf8mb4' );

/** The database collate type. Don't change this if in doubt. */
define( 'DB_COLLATE', '' );

/**#@+
 * Authentication unique keys and salts.
 *
 * Change these to different unique phrases! You can generate these using
 * the {@link https://api.wordpress.org/secret-key/1.1/salt/ WordPress.org secret-key service}.
 *
 * You can change these at any point in time to invalidate all existing cookies.
 * This will force all users to have to log in again.
 *
 * @since 2.6.0
 */
define( 'AUTH_KEY',         'my+6Tc<1;p5)Z>HQ)Z^m5dNDp?G>*x0n7g7z,f {OKV!=0s.} iJQ3V S5|bdl~>' );
define( 'SECURE_AUTH_KEY',  '_YhC#f%3 #o:9`<Cls#%8A^;;-qDZ`Xba#j8G<ht,Gg;J725R+FR/za/u4@#6,XI' );
define( 'LOGGED_IN_KEY',    '83I4A>#,/iOAYI1pm*gE<_?hiSg-ln1;zh#`*J2p]`<zd.#Nch?RKa6x-cS5!f-d' );
define( 'NONCE_KEY',        '@Lo8L6^PaYNY[([lBbrfH4?JUHhG*&,]U|R?[0b/(W^QNO@-`_Cm(~kI`k5OS&69' );
define( 'AUTH_SALT',        'm?!Do&L;mg[U,E|iE#4{s@LfAg]{_n1fs/Gz5g9iNM5I7BsP hdE7E&_P>jmu;>q' );
define( 'SECURE_AUTH_SALT', 'H<F95Vj3fY]tMSmF!Z3-aFJ?UR1F$2q#8e#1y1CND1,uoV+c8g;>n}pS5i[7t7!_' );
define( 'LOGGED_IN_SALT',   'LszBz>l=rMd2kmj,eUBinqW|mvw9.AdVm|HC)[@a%0c[>w<T8qjHc`MWi#cZ8-+g' );
define( 'NONCE_SALT',       'D*,zMV3OmCCe#skMpQ 6R0w@/,CZfzS2bA{}s_`,fgA>)W9h$H-,T/_1DJ]^pT$G' );

/**#@-*/

/**
 * WordPress database table prefix.
 *
 * You can have multiple installations in one database if you give each
 * a unique prefix. Only numbers, letters, and underscores please!
 *
 * At the installation time, database tables are created with the specified prefix.
 * Changing this value after WordPress is installed will make your site think
 * it has not been installed.
 *
 * @link https://developer.wordpress.org/advanced-administration/wordpress/wp-config/#table-prefix
 */
$table_prefix = 'wp_';

/**
 * For developers: WordPress debugging mode.
 *
 * Change this to true to enable the display of notices during development.
 * It is strongly recommended that plugin and theme developers use WP_DEBUG
 * in their development environments.
 *
 * For information on other constants that can be used for debugging,
 * visit the documentation.
 *
 * @link https://developer.wordpress.org/advanced-administration/debug/debug-wordpress/
 */
define( 'WP_DEBUG', false );

/* Add any custom values between this line and the "stop editing" line. */



/* That's all, stop editing! Happy publishing. */

/** Absolute path to the WordPress directory. */
if ( ! defined( 'ABSPATH' ) ) {
	define( 'ABSPATH', __DIR__ . '/' );
}

/** Sets up WordPress vars and included files. */
require_once ABSPATH . 'wp-settings.php';
