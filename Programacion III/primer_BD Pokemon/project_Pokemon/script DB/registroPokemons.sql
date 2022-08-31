SELECT 
	Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion as Tipo, D.Descripcion as Debilidad
FROM POKEMONS AS P, ELEMENTOS AS E, ELEMENTOS AS D-- NECESITO PONERLE UN ALIAS, YA QUE HAY "DESCRIPCION" EN LA TABLA "POKEMONS" Y EN "ELEMENTOS"
WHERE E.Id = P.IdTipo -- Trae esos elementos de arriba, siempre y cuando el id de pokemon sea igual al id de elementos
AND D.Id = P.IdDebilidad










