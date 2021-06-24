import pyodbc
import sys

with pyodbc.connect(sys.argv[1]) as conn:
    with conn.cursor() as cursor:
        dropFile = open("DropValues.sql", "r")
        insertFile = open("InsertSeededValues.sql", "r")

        dropQuery = dropFile.read()
        insertQuery = insertFile.read()

        cursor.execute(dropQuery)
        cursor.execute(insertQuery)
