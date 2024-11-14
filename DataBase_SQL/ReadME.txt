Importazione tramite MySQL Workbench
Avvia MySQL Workbench e connettiti al tuo server MySQL.
Vai al menu Database e seleziona Restore Data (in alcune versioni di Workbench si chiama Data Import).
Nella finestra Data Import:
Seleziona l'opzione Import from Self-Contained File e indica il percorso del tuo file .sql.
Nel campo Default Target Schema, seleziona il database in cui desideri importare i dati. Se il database non esiste ancora, crealo prima:
Vai alla sezione Schemas (a sinistra), fai clic con il tasto destro e seleziona Create Schema.
Inserisci il nome del nuovo database e fai clic su Apply.
Fai clic su Start Import. MySQL Workbench inizierà il processo di importazione e, al termine, il database sarà pronto per l'uso.