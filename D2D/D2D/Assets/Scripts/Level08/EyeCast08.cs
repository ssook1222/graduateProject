﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EyeCast08 : MonoBehaviour
{
    private Transform tr;
    private Ray ray;
    private RaycastHit hit;
    public float dist = 10.0f;

    public float time01 = 0.0f;
    public float time02 = 0.0f;
    public float time03 = 0.0f;
    public float time04 = 0.0f;
    public float time05 = 0.0f;
    public float time06 = 0.0f;

    public GameObject player;
    public GameObject sphere02;
    public GameObject sphere03;
    public GameObject sphere04;
    public GameObject sphere05;
    public GameObject sphere06;
    public GameObject sphere07;

    public GameObject UI02;
    public GameObject UI03;
    public GameObject UI04;
    public GameObject UI05;
    public GameObject UI06;
    public GameObject UI07;

    public GameObject UI021;
    public GameObject UI031;
    public GameObject UI041;
    public GameObject UI051;
    public GameObject UI061;

    public GameObject cube01;
    public GameObject cube02;
    public GameObject cube03;
    public GameObject cube04;
    public GameObject cube05;
    public GameObject cube06;
    public GameObject cube07;
    public GameObject cube08;

    private bool start = true;
    private bool arrive01 = false;
    private bool arrive02 = false;
    private bool arrive03 = false;
    private bool arrive04 = false;
    private bool arrive05 = false;
    private bool arrive06 = false;

    private bool a01 = false;
    private bool a02 = false;
    private bool a03 = false;
    private bool a04 = false;
    private bool a05 = false;
   
    private bool no02 = false;
    private bool no03 = false;
    private bool no04 = false;
    private bool no05 = false;

    public GameObject moza02;
    public GameObject moza03;
    public GameObject moza04;
    public GameObject moza05;
    public GameObject moza06;
    public GameObject moza07;

    public GameObject Success;
    public GameObject Fail;

    void Start()
    {
        tr = GetComponent<Transform>();
        UI02.SetActive(false);
        UI03.SetActive(false);
        UI04.SetActive(false);
        UI05.SetActive(false);
        UI06.SetActive(false);
        UI07.SetActive(false);
        Success.SetActive(false);
        Fail.SetActive(false);

        UI021.SetActive(false);
        UI031.SetActive(false);
        UI041.SetActive(false);
        UI051.SetActive(false);
        UI061.SetActive(false);


    }

    void Update()
    {
        Vector3 vec02 = player.GetComponent<Transform>().position - UI02.GetComponent<Transform>().position;
        vec02.Normalize();
        Quaternion q02 = Quaternion.LookRotation(vec02);
        UI02.GetComponent<Transform>().rotation = q02;

        Vector3 vec03 = player.GetComponent<Transform>().position - UI03.GetComponent<Transform>().position;
        vec03.Normalize();
        Quaternion q03 = Quaternion.LookRotation(vec03);
        UI03.GetComponent<Transform>().rotation = q03;

        Vector3 vec04 = player.GetComponent<Transform>().position - UI04.GetComponent<Transform>().position;
        vec04.Normalize();
        Quaternion q04 = Quaternion.LookRotation(vec04);
        UI04.GetComponent<Transform>().rotation = q04;

        Vector3 vec05 = player.GetComponent<Transform>().position - UI05.GetComponent<Transform>().position;
        vec05.Normalize();
        Quaternion q05 = Quaternion.LookRotation(vec05);
        UI05.GetComponent<Transform>().rotation = q05;

        Vector3 vec06 = player.GetComponent<Transform>().position - UI06.GetComponent<Transform>().position;
        vec06.Normalize();
        Quaternion q06 = Quaternion.LookRotation(vec06);
        UI06.GetComponent<Transform>().rotation = q06;

        Vector3 vec07 = player.GetComponent<Transform>().position - UI07.GetComponent<Transform>().position;
        vec07.Normalize();
        Quaternion q07 = Quaternion.LookRotation(vec07);
        UI07.GetComponent<Transform>().rotation = q07;

        //wait
        Vector3 vec08 = player.GetComponent<Transform>().position - UI021.GetComponent<Transform>().position;
        vec08.Normalize();
        Quaternion q08 = Quaternion.LookRotation(vec08);
        UI021.GetComponent<Transform>().rotation = q08;

        Vector3 vec09 = player.GetComponent<Transform>().position - UI031.GetComponent<Transform>().position;
        vec09.Normalize();
        Quaternion q09 = Quaternion.LookRotation(vec09);
        UI031.GetComponent<Transform>().rotation = q09;

        Vector3 vec10 = player.GetComponent<Transform>().position - UI041.GetComponent<Transform>().position;
        vec10.Normalize();
        Quaternion q10 = Quaternion.LookRotation(vec10);
        UI041.GetComponent<Transform>().rotation = q10;

        Vector3 vec11 = player.GetComponent<Transform>().position - UI051.GetComponent<Transform>().position;
        vec11.Normalize();
        Quaternion q11 = Quaternion.LookRotation(vec11);
        UI051.GetComponent<Transform>().rotation = q11;

        Vector3 vec12 = player.GetComponent<Transform>().position - UI061.GetComponent<Transform>().position;
        vec12.Normalize();
        Quaternion q12 = Quaternion.LookRotation(vec12);
        UI061.GetComponent<Transform>().rotation = q12;

      
        ray = new Ray(tr.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * dist, Color.red);

        UI02.SetActive(false);
        UI03.SetActive(false);
        UI04.SetActive(false);
        UI05.SetActive(false);
        UI06.SetActive(false);
        UI07.SetActive(false);

        UI021.SetActive(false);
        UI031.SetActive(false);
        UI041.SetActive(false);
        UI051.SetActive(false);
        UI061.SetActive(false);
        

        if (Physics.Raycast(ray, out hit, dist, 1 << 9))
        {
            if (time01 >= 2.0f && start)
            {
                arrive01 = true; start = false; arrive03 = false; arrive02 = false; arrive06 = false; arrive05 = false; arrive04 = false;
            }

            if (((time02 >= 2.0f && arrive01) || (time02 >= 2.0f && arrive03)|| (time02 >= 2.0f && arrive05)) && !no02)
            {
                arrive02 = true; arrive01 = false; arrive03 = false; arrive05 = false; start = false; arrive04 = false; arrive06 = false;
            }

            if (((time03 >= 2.0f && arrive01) || (time03 >= 2.0f && arrive02)|| (time03 >= 2.0f && arrive04)) && !no03)
            {
                arrive03 = true; arrive02 = false; arrive01 = false; arrive04 = false; start = false; arrive06 = false; arrive05 = false;
            }

            if (((time04 >= 2.0f && arrive03) || (time04 >= 2.0f && arrive05)) && !no04)
            {
                arrive04 = true; arrive05 = false; arrive03 = false; arrive02 = false; arrive01 = false; start = false; arrive06 = false;
            }

            if (((time05 >= 2.0f && arrive02)||(time05 >= 2.0f && arrive04)) && !no05)
            {
                arrive05 = true; arrive04 = false; arrive03 = false; arrive02 = false; arrive01 = false; start = false; arrive06 = false;
            }

            if (time06 >= 2.0f && arrive05)
            {
                arrive06 = true; arrive05 = false; arrive04 = false; arrive03 = false; arrive02 = false; arrive01 = false; start = false;
            }

            GazeButton();

            Color color;
            ColorUtility.TryParseHtmlString("#957745", out color);

            if (time01 >= 2.0f && start)
            {
                cube03.GetComponent<Renderer>().material.color = color;
                moza02.GetComponent<Renderer>().material.color = Color.blue;
                a01 = true;
            }

            if (time02 >= 2.0f && arrive01)
            {
                cube04.GetComponent<Renderer>().material.color = color;
                moza03.GetComponent<Renderer>().material.color = Color.blue;
                a02 = true;
            }

            if (time03 >= 2.0f && arrive04)
            {
                cube06.GetComponent<Renderer>().material.color = color;
                moza04.GetComponent<Renderer>().material.color = Color.blue;
                a03 = true;
                no02 = true;
            }

            if (time02 >= 2.0f && arrive03 && !no02)
            {
                cube08.GetComponent<Renderer>().material.color = color;
                moza03.GetComponent<Renderer>().material.color = Color.blue;
                a02 = true;
                no03 = true;
            }

            if (time02 >= 2.0f && arrive05 && !no02)
            {
                cube02.GetComponent<Renderer>().material.color = color;
                moza03.GetComponent<Renderer>().material.color = Color.blue;
                a02 = true;
                no05 = true;
                no03 = true; // for 실패 시나리오 03
            }

            if (time03 >= 2.0f && arrive02)
            {
                cube08.GetComponent<Renderer>().material.color = color;
                moza04.GetComponent<Renderer>().material.color = Color.blue;
                a03 = true;
                no02 = true;
            }

            if (time03 >= 2.0f && arrive01)
            {
                cube05.GetComponent<Renderer>().material.color = color;
                moza04.GetComponent<Renderer>().material.color = Color.blue;
                a03 = true;
            }

            if (time04 >= 2.0f && arrive03)
            {
                cube06.GetComponent<Renderer>().material.color = color;
                moza05.GetComponent<Renderer>().material.color = Color.blue;
                a04 = true;
            }

            if (time04 >= 2.0f && arrive05)
            {
                cube07.GetComponent<Renderer>().material.color = color;
                moza05.GetComponent<Renderer>().material.color = Color.blue;
                a04 = true;
                no05 = true;
            }

            if (time05 >= 2.0f && arrive04)
            {
                cube07.GetComponent<Renderer>().material.color = color;
                moza06.GetComponent<Renderer>().material.color = Color.blue;
                a05 = true;
                no04 = true;
            }

            if (time05 >= 2.0f && arrive02 && !no02)
            {
                cube02.GetComponent<Renderer>().material.color = color;
                moza06.GetComponent<Renderer>().material.color = Color.blue;
                a05 = true;
            }

            if (arrive06)
            {
                cube01.GetComponent<Renderer>().material.color = color;
                moza07.GetComponent<Renderer>().material.color = Color.blue;
            }

            if ((cube03.GetComponent<Renderer>().material.color == color) && (cube04.GetComponent<Renderer>().material.color == color)
                && (cube08.GetComponent<Renderer>().material.color == color) && (cube06.GetComponent<Renderer>().material.color == color)
                && (cube07.GetComponent<Renderer>().material.color == color) && (cube01.GetComponent<Renderer>().material.color == color))
            {
               // Debug.Log("성공");
                Success.SetActive(true);
            }

            if ((cube03.GetComponent<Renderer>().material.color == color) && (cube05.GetComponent<Renderer>().material.color == color)
                && (cube08.GetComponent<Renderer>().material.color == color) && (cube02.GetComponent<Renderer>().material.color == color)
                && (cube01.GetComponent<Renderer>().material.color == color))
            {
                // Debug.Log("실패");
                Fail.SetActive(true);
            }

            if ((cube03.GetComponent<Renderer>().material.color == color) && (cube05.GetComponent<Renderer>().material.color == color)
                && (cube06.GetComponent<Renderer>().material.color == color) && (cube07.GetComponent<Renderer>().material.color == color)
                && (cube01.GetComponent<Renderer>().material.color == color))
            {
                // Debug.Log("실패");
                Fail.SetActive(true);
            }

            if ((cube03.GetComponent<Renderer>().material.color == color) && (cube05.GetComponent<Renderer>().material.color == color)
                && (cube06.GetComponent<Renderer>().material.color == color) && (cube07.GetComponent<Renderer>().material.color == color)
                && (cube02.GetComponent<Renderer>().material.color == color))
            {
                // Debug.Log("실패");
                Fail.SetActive(true);
            }

            if ((cube03.GetComponent<Renderer>().material.color == color) && (cube05.GetComponent<Renderer>().material.color == color)
                && (cube08.GetComponent<Renderer>().material.color == color) && (cube02.GetComponent<Renderer>().material.color == color)
                && (cube01.GetComponent<Renderer>().material.color == color))
            {
                //Debug.Log("실패");
                Fail.SetActive(true);
            }

            if ((cube03.GetComponent<Renderer>().material.color == color) && (cube04.GetComponent<Renderer>().material.color == color)
                && (cube02.GetComponent<Renderer>().material.color == color) && (cube01.GetComponent<Renderer>().material.color == color))
            {
                //Debug.Log("실패");
                Fail.SetActive(true);
            }

            if ((cube03.GetComponent<Renderer>().material.color == color) && (cube04.GetComponent<Renderer>().material.color == color)
                && (cube02.GetComponent<Renderer>().material.color == color) && (cube07.GetComponent<Renderer>().material.color == color)
                && (cube06.GetComponent<Renderer>().material.color == color))
            {
                //Debug.Log("실패");
                Fail.SetActive(true);
            }
        }
        else
        {
            time01 = 0.0f;
            time02 = 0.0f;
            time03 = 0.0f;
            time04 = 0.0f;
            time05 = 0.0f;
            time06 = 0.0f;
        }


        if (arrive01)
        {
            player.GetComponent<Transform>().position = Vector3.MoveTowards(player.GetComponent<Transform>().position, sphere02.GetComponent<Transform>().position, 0.08f);
        }

        if (arrive02 && !no02)
        {
            player.GetComponent<Transform>().position = Vector3.MoveTowards(player.GetComponent<Transform>().position, sphere03.GetComponent<Transform>().position, 0.08f);
        }

        if (arrive03 && !no03)
        {
            player.GetComponent<Transform>().position = Vector3.MoveTowards(player.GetComponent<Transform>().position, sphere04.GetComponent<Transform>().position, 0.08f);
        }

        if (arrive04 && !no04)
        {
            player.GetComponent<Transform>().position = Vector3.MoveTowards(player.GetComponent<Transform>().position, sphere05.GetComponent<Transform>().position, 0.08f);
        }

        if (arrive05 && !no05)
        {
            player.GetComponent<Transform>().position = Vector3.MoveTowards(player.GetComponent<Transform>().position, sphere06.GetComponent<Transform>().position, 0.08f);
        }

        if (arrive06)
        {
            player.GetComponent<Transform>().position = Vector3.MoveTowards(player.GetComponent<Transform>().position, sphere07.GetComponent<Transform>().position, 0.08f);
        }
    }

    void GazeButton()
    {
        if (hit.collider.gameObject.tag == "sphere02")
        {
            if (a01)
                UI02.SetActive(true);
            else
                UI021.SetActive(true);
            time01 += Time.deltaTime;
        }

        if (hit.collider.gameObject.tag == "sphere03")
        {
            if (a02)
                UI03.SetActive(true);
            else
                UI031.SetActive(true);
            time02 += Time.deltaTime;
        }

        if (hit.collider.gameObject.tag == "sphere04")
        {
            if (a03)
                UI04.SetActive(true);
            else
                UI041.SetActive(true);
            time03 += Time.deltaTime;
        }

        if (hit.collider.gameObject.tag == "sphere05")
        {
            if (a04)
                UI05.SetActive(true);
            else
                UI051.SetActive(true);
            time04 += Time.deltaTime;
        }

        if (hit.collider.gameObject.tag == "sphere06")
        {
            if (a05)
                UI06.SetActive(true);
            else
                UI061.SetActive(true);
            time05 += Time.deltaTime;
        }

        if (hit.collider.gameObject.tag == "sphere07")
        {
            UI07.SetActive(true);
            time06 += Time.deltaTime;
        }
    }
}