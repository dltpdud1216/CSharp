using UnityEngine;
using System.Linq;
using System.Collections.Generic;


public class LinqSort : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //리스트 데이터 정렬
        //리스트 제네릭 클래스 인스턴스 생성 및 초기화
        List<string> colos = new List<string> { "Red", "Blue", "Green" };

        //오름차순 정렬
        var sortedColos = colos.OrderBy(c => c).ToList();

        foreach (var color in sortedColos)
        {
            Debug.Log(color);
        }

        Debug.Log($"=====================");

        //내림차순 정렬
        var deSortedColors = colos.OrderByDescending(c=>c).ToList();

        foreach (var color in deSortedColors)
        {
            Debug.Log(color);

        }
    }

 
}
