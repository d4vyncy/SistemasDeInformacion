<?php

class M_Usuariologueado extends \DB\SQL\Mapper
{
  public function __construct()
  {
    parent::__construct(\Base::instance()->get('DB'), 'usuario');
  }
  
}
