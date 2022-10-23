import model

def printPhonbook():
    print()
    for index, item in enumerate(model.phonebook):
        print(index, item)

def print_main_menu():
    print('\nГлавное меню')
    print('0. Просмотреть контакты')
    print('1. Открыть файл с контактами')
    print('2. Записать файл с контактами')
    print('3. Добавить контакт')
    print('4. Изменить контакт')
    print('5. Удалить контакт')
    print('6. Поиск по контактам')
    print('7. Выйти из программы')
