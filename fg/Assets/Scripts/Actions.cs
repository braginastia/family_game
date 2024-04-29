using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class Actions : MonoBehaviour
{
    bool move; //Есть возможность перемещать объект или возможность блокируется при размещении объекта в нужном месте
    Vector2 mousePos; //Позиция курсора
    float startPosX; //Начальное положение объекта по Х
    float startPosY; //Начальное положение объекта по У
    public GameObject form; //Прозрачная форма с нужной позицией
    private bool placed = false; //Определяем разместили ли пазл в нужном месте, по умолчанию нет
    void OnMouseDown ()
    {
        if (Input.GetMouseButtonDown(0)) //Когда пользователь нажимает левой клавишей мыши
        {
            move = true; //Разрешаем перемещение
            mousePos = Input.mousePosition; //Получаем координаты курсора
            startPosX = mousePos.x - this.transform.localPosition.x; //Записываем стартовое положение по Х
            startPosY = mousePos.y - this.transform.localPosition.y; //Записываем стартовое положение по У
        }
    }


    void OnMouseUp() //Когда пользователь отпускает лувую клавишу мыши
    {
        move = false; //Запрещает перемещение
        //Если пазл рядом со своим местом, то перемещаем его туда и запрезаем дальнейшее перемещение
        if (Mathf.Abs(this.transform.localPosition.x - form.transform.localPosition.x)<= 25f &&
            Math.Abs(this.transform.localPosition.y - form.transform.localPosition.y) <= 25f)
    {
            if (!placed) //Проверяем, не был ли объект уже установлен на место
            {
                WinScript.AddElement(); //Увеличиваем количество элементов на своем месте
                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
                this.transform.position = new Vector2(form.transform.position.x, form.transform.position.y);
                if (spriteRenderer != null)
                {
                    spriteRenderer.sortingOrder = 1;
                }
                placed = true;
                GetComponent<BoxCollider2D>().enabled = false;
            }

        }
    }
}
