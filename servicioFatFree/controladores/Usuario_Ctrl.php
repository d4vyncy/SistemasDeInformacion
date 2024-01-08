<?php
//gen 11/11/2020 18:15:01 dst
class Usuario_Ctrl
{
    public $M_Usuariologueado = null;
    public function __construct()
    {
        $this->M_Usuariologueado = new M_Usuariologueado();
    }

    public function selUsuario($f3)
    {
      
          
            
            $Con = "select * from usuario";
            $sql = $Con;
       
                $resulto = $f3->get('DB')->exec($sql);
                $items = array();
                $msg = 'Lista de Usuarios';
                $items = $resulto;
                echo json_encode([
                    'mesaje' => $msg,
                    'info' => [
                        'item' => $items
                    ]
                ]);
            
      
    }

    public function addUsuario($f3)
    {
        
            $Tipo = 'C';
            $pid = is_null($f3->get('POST.pid')) ? 'T' : $f3->get('POST.pid');
            $pnombreusuario = is_null($f3->get('POST.pnombreusuario')) ? 'T' : $f3->get('POST.pnombreusuario');
            $ppass = is_null($f3->get('POST.ppass')) ? 'T' : $f3->get('POST.ppass');
            $pestado = is_null($f3->get('POST.pestado')) ? 'T' : $f3->get('POST.pestado');            
            $sql = "CALL pagusuario('" . $Tipo . "','" . $pid . "','" . $pnombreusuario . "','" . $ppass . "','" . $pestado. "'); ";
           
                $resulto = $f3->get('DB')->exec($sql);
                $items = array();
                $msg = 'add Usuario';
                $items = $resulto;
                echo json_encode([
                    'mesaje' => $msg,
                    'info' => [
                        'item' => $items
                    ]
                ]);
            
       
    }

    public function getUsuario($f3)
    {
        $idusuario = is_null($f3->get('POST.idusuario')) ? 'T' : $f3->get('POST.idusuario');
        $llave = is_null($f3->get('POST.llave')) ? 'T' : $f3->get('POST.llave');
        if ($this->M_Usuariologueado->ValidaSession($idusuario, $llave)) {
            $Tipo = 'R';
            $idusuario = is_null($f3->get('POST.pidusuario')) ? 'T' : $f3->get('POST.pidusuario');
            $idpersona = is_null($f3->get('POST.pidpersona')) ? 'T' : $f3->get('POST.pidpersona');
            $nombreusuario = is_null($f3->get('POST.pnombreusuario')) ? 'T' : $f3->get('POST.pnombreusuario');
            $clave = is_null($f3->get('POST.pclave')) ? 'T' : $f3->get('POST.pclave');
            $salt = is_null($f3->get('POST.psalt')) ? 'T' : $f3->get('POST.psalt');
            $pin = is_null($f3->get('POST.ppin')) ? 'T' : $f3->get('POST.ppin');
            $idestadousuario = is_null($f3->get('POST.pidestadousuario')) ? 'T' : $f3->get('POST.pidestadousuario');
            $idtipousuario = is_null($f3->get('POST.pidtipousuario')) ? 'T' : $f3->get('POST.pidtipousuario');
            $estilo = is_null($f3->get('POST.pestilo')) ? 'T' : $f3->get('POST.pestilo');
            $idcorporacion = is_null($f3->get('POST.pidcorporacion')) ? 'T' : $f3->get('POST.pidcorporacion');
            $idempresa = is_null($f3->get('POST.pidempresa')) ? 'T' : $f3->get('POST.pidempresa');
            $idsucursal = is_null($f3->get('POST.pidsucursal')) ? 'T' : $f3->get('POST.pidsucursal');
            $sql = "CALL pcruUsuario('" . $Tipo . "','" . $idusuario . "','" . $idpersona . "','" . $nombreusuario . "','" . $clave . "','" . $salt . "','" . $pin . "','" . $idestadousuario . "','" . $idtipousuario . "','" . $estilo . "','" . $idcorporacion . "','" . $idempresa . "','" . $idsucursal . "'); ";
            try {
                $resulto = $f3->get('DB')->exec($sql);
                $items = array();
                $msg = 'getUsuario';
                $items = $resulto;
                echo json_encode([
                    'mesaje' => $msg,
                    'info' => [
                        'item' => $items
                    ]
                ]);
            } catch (PDOException $e) {
                echo json_encode('{"error" : { "text":' . $e->getMessage() . '}');
                $resulto = $f3->get('DB')->exec($sql);
                $items = array();
                $msg = 'Usuario encontrada';
                $items = $resulto;
                echo json_encode([
                    'mesaje' => $msg,
                    'info' => [
                        'item' => $items
                    ]
                ]);
            } catch (PDOException $e) {
                echo json_encode('{"error" : { "text":' . $e->getMessage() . '}');
            }
        } else {
            $msg = 'llave no valida';
            $items = '';
            echo json_encode([
                'mesaje' => $msg,
                'info' => [
                    'item' => $items
                ]
            ]);
        }
    }

    public function updUsuario($f3)
    {
        $idusuario = is_null($f3->get('POST.idusuario')) ? 'T' : $f3->get('POST.idusuario');
        $llave = is_null($f3->get('POST.llave')) ? 'T' : $f3->get('POST.llave');
        if ($this->M_Usuariologueado->ValidaSession($idusuario, $llave)) {
            $Tipo = 'U';
            $idusuario = is_null($f3->get('POST.pidusuario')) ? 'T' : $f3->get('POST.pidusuario');
            $idpersona = is_null($f3->get('POST.pidpersona')) ? 'T' : $f3->get('POST.pidpersona');
            $nombreusuario = is_null($f3->get('POST.pnombreusuario')) ? 'T' : $f3->get('POST.pnombreusuario');
            $clave = is_null($f3->get('POST.pclave')) ? 'T' : $f3->get('POST.pclave');
            $salt = is_null($f3->get('POST.psalt')) ? 'T' : $f3->get('POST.psalt');
            $pin = is_null($f3->get('POST.ppin')) ? 'T' : $f3->get('POST.ppin');
            $idestadousuario = is_null($f3->get('POST.pidestadousuario')) ? 'T' : $f3->get('POST.pidestadousuario');
            $idtipousuario = is_null($f3->get('POST.pidtipousuario')) ? 'T' : $f3->get('POST.pidtipousuario');
            $estilo = is_null($f3->get('POST.pestilo')) ? 'T' : $f3->get('POST.pestilo');
            $idcorporacion = is_null($f3->get('POST.pidcorporacion')) ? 'T' : $f3->get('POST.pidcorporacion');
            $idempresa = is_null($f3->get('POST.pidempresa')) ? 'T' : $f3->get('POST.pidempresa');
            $idsucursal = is_null($f3->get('POST.pidsucursal')) ? 'T' : $f3->get('POST.pidsucursal');
            $sql = "CALL pcruUsuario('" . $Tipo . "','" . $idusuario . "','" . $idpersona . "','" . $nombreusuario . "','" . $clave . "','" . $salt . "','" . $pin . "','" . $idestadousuario . "','" . $idtipousuario . "','" . $estilo . "','" . $idcorporacion . "','" . $idempresa . "','" . $idsucursal . "'); ";
            try {
                $resulto = $f3->get('DB')->exec($sql);
                $items = array();
                $msg = 'update Usuario';
                $items = $resulto;
                echo json_encode([
                    'mesaje' => $msg,
                    'info' => [
                        'item' => $items
                    ]
                ]);
            } catch (PDOException $e) {
                echo json_encode('{"error" : { "text":' . $e->getMessage() . '}');
                $resulto = $f3->get('DB')->exec($sql);
                $items = array();
                $msg = 'Usuario encontrada';
                $items = $resulto;
                echo json_encode([
                    'mesaje' => $msg,
                    'info' => [
                        'item' => $items
                    ]
                ]);
            } catch (PDOException $e) {
                echo json_encode('{"error" : { "text":' . $e->getMessage() . '}');
            }
        } else {
            $msg = 'llave no valida';
            $items = '';
            echo json_encode([
                'mesaje' => $msg,
                'info' => [
                    'item' => $items
                ]
            ]);
        }
    }
}
