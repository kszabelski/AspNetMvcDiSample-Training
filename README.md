AspNetMvcDiSample
=================

This repository is created for training purposes and contains sample and simple integration of Autofac DI container with ASP.NET MVC application


# Steps

Start from:

git checkout 0_starting_point

Implementations are trivial - no edge cases covered etc. Let's just focus on DI

## 1) Make ShouldCalculateExchangeRate test pass by implementing CurrencyCalculator

After this you should have implementation of calculator using Constructor Injection to define reference on IExchangeRateRepository

## 2) Implement controller implementing Composition Root directly in controller 

After this you should have working UI but falling controller test

## 3) Refactor controller towards Constructor Injection and fix controller test

After this you should have passing tests but not working UI.

## 4) Implement Poor man's DI using ControllerBuilder.Current.SetControllerFactory()

After this all should work, but it is poorly maintainable solution

## 5) Implement DI using Autofac and Autofac.Mvc4

install-package autofac

install-package autofac.Mvc4
