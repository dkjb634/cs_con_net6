select a.id
  from foo a,
       bar b
 where a.id = b.id
   and b.name = "Dmitry"