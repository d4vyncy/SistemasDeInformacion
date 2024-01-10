
<?php
//gen davidserrudoqgmail.com

class Dav_Ctrol
{
    public $M_Usuario = null;
    public $M_Usuariologueado = null;
    public function __construct()
    {
        $this->M_Usuario = new M_Usuario();
        $this->M_Usuariologueado = new M_Usuariologueado();
    }
    public function ValidaUser($f3)
    {
        $permitted_chars = '0123456789abcdefghijklmnopqrstuvwxyz';
        // Output: 54esmdr0qf
        $permitted_chars = substr(str_shuffle($permitted_chars), 0, 10);
        $msg = 'OK';
        $nombreusuario = is_null($f3->get('POST.nombreusuario')) ? 'T' : $f3->get('POST.nombreusuario');
        $clave = is_null($f3->get('POST.clave')) ? '' : $f3->get('POST.clave');
        $this->M_Usuario->load(['nombreusuario = ?', $nombreusuario]);
        $pclave  = $this->M_Usuario->get('clave');
         if ($this->validate_pw($clave, $pclave)) {
                 
            $idusuariologueado = $this->M_Usuario->get('idusuario');
            $idusuario =  $this->M_Usuario->get('idusuario');                        
            $llave = crypt($permitted_chars,date("Y-m-d H:i:s"));
            $idestadollave = 1;
            $fecha = date("Y-m-d H:i:s");
            
            $sql = "CALL pcontrol('" .$idusuariologueado . "','" . $idusuario  . "','" . $llave . "','" . $idestadollave . "','" . $fecha . "'); ";
            $resulto = $f3->get('DB')->exec($sql);
            $this->M_Usuariologueado->load(['idusuario = ? and idestadollave=1', $idusuariologueado]);
            $items = array();
            //devolvemos el objeto
            $items = $this->M_Usuariologueado->cast();
        } else {
            $msg = 'FAILD';
            $items = '';
        }
        echo json_encode([
            'mesaje' => $msg,
            'info' => [
                'item' => $items
            ]
        ]);
        
    }
    
   
    
    function validate_pw($password, $hash)
    {
        /* Regenerating the with an available hash as the options parameter should
         * produce the same hash if the same password is passed.
         */
        return crypt($password, $hash) == $hash;
    }
    public function fnDevuelveConsulta(
        string $NombreVista,
        string $Campo0,
        string $Valor0,
        string $Campo1,
        string $Valor1,
        string $Campo2,
        string $Valor2,
        string $Campo3,
        string $Valor3,
        string $Campo4,
        string $Valor4,
        string $Campo5,
        string $Valor5,
        string $Campo6,
        string $Valor6,
        string $Campo7,
        string $Valor7
    ) {
        $ps = "";
        $ps = $this->fnDevuelveCondicion($Campo0, $Valor0);
        $ps = $ps . $this->fnDevuelveCondicion($Campo1, '.' . $Valor1);
        $ps = $ps . $this->fnDevuelveCondicion($Campo2, '.' . $Valor2);
        $ps = $ps . $this->fnDevuelveCondicion($Campo3, '.' . $Valor3);
        $ps = $ps . $this->fnDevuelveCondicion($Campo4, '.' . $Valor4);
        $ps = $ps . $this->fnDevuelveCondicion($Campo5, '.' . $Valor5);
        $ps = $ps . $this->fnDevuelveCondicion($Campo6, '.' . $Valor6);
        $ps = $ps . $this->fnDevuelveCondicion($Campo7, '.' . $Valor7);
        $ps = 'SELECT  * from  ' . $NombreVista . $ps;
        return $ps;
    }
    public function fnDevuelveCondicion(string $Campo, string $Valor)
    {
        //         string s = "good overview of ESP's in more detail than you probably need.";
        // string escaped = s.Replace("'","''");
        $Condicion = "";
        $Campo = str_replace("'", "", $Campo);
        $Valor = str_replace("'", "", $Valor);
        #consultamos un where
        if (substr($Valor, 0, 1) <> ".")
            $Condicion = " WHERE ";
        else {
            if (substr($Valor, 1, 2) == ".") {
                $Condicion = " OR ";
                $Valor = substr($Valor, 2, strlen($Valor));
            } else {
                $Condicion = " AND ";
                $Valor = substr($Valor, 1, strlen($Valor));
            }
        }
        #preguntas
        if (substr($Campo, 0, 1) == "C")
            $Condicion = $Condicion . substr($Campo, 1, strlen($Campo)) . " like " . "'" . $Valor . "%" . "'";
            // $Condicion = $Condicion . substr($Campo, 1, strlen($Campo)) . " like " . "'" . "%" . $Valor . "%" . "'";

     
        if (substr($Campo, 0, 1) ==  "T") {
            $Condicion = "";
        }

        if (substr($Campo, 0, 1) ==  "L") {
            $Condicion = $Condicion .  "" .  substr($Campo, 1, strlen($Campo)) . " = " . "'" .  $Valor .  "'";
        }
   

        #retornamos $Valor
        return $Condicion;
    }
}
