using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class Actions : MonoBehaviour
{
    bool move; //���� ����������� ���������� ������ ��� ����������� ����������� ��� ���������� ������� � ������ �����
    Vector2 mousePos; //������� �������
    float startPosX; //��������� ��������� ������� �� �
    float startPosY; //��������� ��������� ������� �� �
    public GameObject form; //���������� ����� � ������ ��������
    private bool placed = false; //���������� ���������� �� ���� � ������ �����, �� ��������� ���
    void OnMouseDown ()
    {
        if (Input.GetMouseButtonDown(0)) //����� ������������ �������� ����� �������� ����
        {
            move = true; //��������� �����������
            mousePos = Input.mousePosition; //�������� ���������� �������
            startPosX = mousePos.x - this.transform.localPosition.x; //���������� ��������� ��������� �� �
            startPosY = mousePos.y - this.transform.localPosition.y; //���������� ��������� ��������� �� �
        }
    }


    void OnMouseUp() //����� ������������ ��������� ����� ������� ����
    {
        move = false; //��������� �����������
        //���� ���� ����� �� ����� ������, �� ���������� ��� ���� � ��������� ���������� �����������
        if (Mathf.Abs(this.transform.localPosition.x - form.transform.localPosition.x)<= 25f &&
            Math.Abs(this.transform.localPosition.y - form.transform.localPosition.y) <= 25f)
    {
            if (!placed) //���������, �� ��� �� ������ ��� ���������� �� �����
            {
                WinScript.AddElement(); //����������� ���������� ��������� �� ����� �����
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
