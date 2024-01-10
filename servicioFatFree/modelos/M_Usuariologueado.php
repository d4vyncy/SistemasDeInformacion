<?php

class M_Usuariologueado extends \DB\SQL\Mapper
{
  public function __construct()
  {
    parent::__construct(\Base::instance()->get('DB'), 'usuariologueado');
  }
   // public function ValidaSession(string $idusuario, string $Clave): bool
   public function ValidaSession( $idusuario=null, $Clave=null)
   {
     $this->load(["idusuario = $idusuario and idestadollave=1 and llave = '$Clave'"]);
     if ($this->loaded() > 0)
       return true;
     else
       return false;
   }
}
