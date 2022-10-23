

import view
import model

def main_menu():
    while True:
        view.print_main_menu()
        choice = int(input('Выберите пункт: '))
        match (choice):
            case 0:
                view.printPhonbook()
            case 1:
                open_file()
               
            case 2:
                save_file()

            case 3: 
                print('\nДобавить контакт?\n') 
                exit = int(input('1 - Выполнить; 0 - Выход\n'))
                if exit != 0:
                    add_contact()
                    print('\nКонтакт добавлен\n')
                    save_file()
            case 4:
                print('\nИзменить контакт?\n') 
                exit = int(input('1 - Выполнить; 0 - Выход\n'))
                if exit != 0:
                    change_contact()
                    print('\nКонтакт изменён\n')
                    save_file()
            case 5:
                print('\nУдалить контакт?\n') 
                exit = int(input('1 - Выполнить; 0 - Выход\n'))
                if exit != 0:
                    remove_contact()
                    print('\nКонтакт удалён\n')
                    save_file()
            case 6:
                print('\nОсуществить поиск контакта?\n') 
                exit = int(input('1 - Выполнить; 0 - Выход\n'))
                if exit != 0:
                    find_contact()
            case 7:
                break

def start():
    open_file()
    main_menu()

def open_file():
    with open (model.path,"r",encoding="UTF-8") as data:
        contacts_List = data.read().split('\n')
        model.phonebook = contacts_List
    
def add_contact():
    name = input('Введите имя: ')
    surname = input('Введите фамилию: ')
    last_name = input('Введите отчество: ')
    phone = input('Введите телефон: ')
    contact = f'{name}; {surname}; {last_name}; {phone};\n'
    model.phonebook.append(contact)
    view.printPhonbook()
    save_file()

def remove_contact():
    choice = int(input('Введите порядковый номер контакта для удаления: '))
    model.phonebook.pop(choice)
    view.printPhonbook()
    save_file()

def save_file():
    print('\nСохранить изменения в файле?\n') 
    save = int(input('1 - Выполнить; 0 - Выход\n'))
    if save != 0:
        with open (model.path,"w",encoding="UTF-8") as data:
            data.write(('\n'.join(model.phonebook)))    
            print('\nФайл сохранён\n') 
            main_menu()
    else:
        main_menu()

def change_contact():
    choice = int(input('Введите порядковый номер контакта для изменения: '))
    choice2 = int(input('Что изменяем (0-Имя, 1-Фамилия, 2-Отчество, 3-Телефон)?: '))
    contact = model.phonebook.pop(choice).split(';')    # Разбиваем список по ";" и выдёргиваем интересующий нас элемент
    contact[choice2] = input('Введите новое значение: ')
    model.phonebook.insert(choice, ';'.join(contact))   # Добавляем новый элемент и склеиваем по ';'
    view.printPhonbook()
    save_file()
        
def find_contact():
    find = int(input('Введите критерий для поиска контакта:(0-Имя, 1-Фамилия, 2-Отчество, 3-Телефон)?:\n'))
    dicts = {}
    key = range(len(model.phonebook))
    value = model.phonebook
    for i in key:
        if value[i] != '':
            dicts[i] = value[i].split(' ;')
    print(dicts)
    
    match (find):
            case 0:
                name = input('Введите имя для поиска\n') 
                for value in dicts.values():
                    find_name = value[0].split('; ')
                    if find_name[0] == name:
                        print(*value)
                    else:
                        un_find ()
            case 1:
                surname = input('Введите фамилию для поиска\n') 
                
                for value in dicts.values():
                    find_name = value[0].split('; ')
                    if find_name[1] == surname:
                        print(*value)
                    else:
                        un_find ()
            case 2:
                lastname = input('Введите отчество для поиска\n') 
                for value in dicts.values():
                    find_name = value[0].split('; ')
                    if find_name[2] == lastname:
                        print(*value)
                    else:
                        un_find ()
            case 3:                            
                phone = input('Введите телефон для поиска\n') 
                for value in dicts.values():
                    find_name = value[0].split('; ')
                    if find_name[3] == phone:
                        print(*value)
                    else:
                        un_find ()

def un_find ():
    print('Контакт не найден, добавить контакт?')
    new = int(input('1 - Выполнить; 0 - Выход\n'))
    if new != 0:
        add_contact()
    else:
        main_menu()

    
        


 
                




