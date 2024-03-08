<a href="https://github.com/sponsors/FANMixco/" target="_blank">
   <img src="https://raw.githubusercontent.com/FANMixco/Xamarin-SearchBar/master/bmc-rezr5vpd.gif" alt="sponsor" />
</a>

# BubbleTab-Xamarin

Based on Florent CHAMPIGNY's version: https://github.com/florent37/BubbleTab

Put some bubble in your tabs and give your apps a supa fresh style!

[![screen](https://raw.githubusercontent.com/florent37/BubbleTab/master/media/withScreen_cropped.png)](https://github.com/florent37/BubbleTab)

# Usage

[![screen](https://raw.githubusercontent.com/florent37/BubbleTab/master/media/video.gif)](https://github.com/florent37/BubbleTab)

Add a BubbleTab with your icons on the layout.xml

Customisable parameters :
- circleColor
- circleRatio

```xml
<com.github.florent37.bubbletab.BubbleTab
        android:id="@+id/bubbleTab"
        android:layout_width="match_parent"
        android:layout_height="wrap_content"
        android:clipToPadding="false"
        android:background="@android:color/white"
        android:elevation="10dp"

        app:bubbleTab_circleColor="@color/colorAccent"
        app:bubbleTab_circleRatio="1.25"
        >

                <ImageView
                    android:layout_width="match_parent"
                    android:layout_height="match_parent"
                    android:layout_weight="1"
                    android:padding="16dp"
                    android:src="@drawable/bubbletab_ic_hourglass_selector" />

                <ImageView
                    android:layout_width="match_parent"
                    android:layout_height="match_parent"
                    android:layout_weight="1"
                    android:padding="16dp"
                    android:src="@drawable/bubbletab_ic_event_selector" />

                <ImageView
                    android:layout_width="match_parent"
                    android:layout_height="match_parent"
                    android:layout_weight="1"
                    android:padding="16dp"
                    android:src="@drawable/bubbletab_ic_query_selector" />

                <ImageView
                    android:layout_width="match_parent"
                    android:layout_height="match_parent"
                    android:layout_weight="1"
                    android:padding="16dp"
                    android:src="@drawable/bubbletab_ic_search_selector" />

                <ImageView
                    android:layout_width="match_parent"
                    android:layout_height="match_parent"
                    android:layout_weight="1"
                    android:padding="16dp"
                    android:src="@drawable/bubbletab_ic_home_selector" />

</com.github.florent37.bubbletab.BubbleTab>

<androidx.viewpager2.widget.ViewPager2
    android:id="@+id/viewPager"
    android:layout_width="match_parent"
    android:layout_height="match_parent"/>
```

Then bound it with your viewPager

```csharp
bubbleTab.SetupWithViewPager(viewPager2);
```

# Customisation

To display your home icon with a different color / content if selected / unselected

Simply use selectors !

[![screen](https://raw.githubusercontent.com/florent37/BubbleTab/master/media/different_icon.gif)](https://github.com/florent37/BubbleTab)

```xml
<?xml version="1.0" encoding="utf-8"?>
<selector xmlns:android="http://schemas.android.com/apk/res/android">
    <item android:state_selected="true" android:drawable="@drawable/bubbletab_ic_account_selected"/>
    <item android:drawable="@drawable/bubbletab_ic_account"/>
</selector>
```

# Download

|  Package  |Latest Release|
|:----------|:------------:|
|**BubbleTabs.Xamarin**|[![NuGet Badge Xamarin-MaterialSearchBar](https://buildstats.info/nuget/BubbleTabs.Xamarin)](https://www.nuget.org/packages/BubbleTabs.Xamarin/)|

```
Install-Package BubbleTabs.Xamarin -Version 2.0.0.1
```

# Credits

Author: Federico Navarrete

### Follow me at:

|  LinkedIn  |YouTube|Amazon|Goodreads|Instagram|Cyber Prophets|Sharing Your Stories|
|:----------|:------------:|:------------:|:------------:|:------------:|:------------:|:------------:|
|[![LinkedIn](https://i.stack.imgur.com/idQWu.png)](https://bit.ly/lfanmixco)|[![YouTube](https://i.stack.imgur.com/CFPMR.png)](https://youtube.com/c/FedericoNavarrete)|[![Amazon](https://i.stack.imgur.com/NFOeE.png)](https://www.amazon.com/Federico-Navarrete/e/B08NJTXQRV)|[![Goodreads](https://i.stack.imgur.com/oBk0g.jpg)](https://www.goodreads.com/author/show/21125413.Federico_Navarrete)|[![Instagram](https://i.stack.imgur.com/PIfqY.png)](https://www.instagram.com/federico_the_consultant)|[![RedCircle Podcast](https://i.stack.imgur.com/4XICF.png)](https://redcircle.com/shows/cyber-prophets)|[![RedCircle Podcast](https://i.stack.imgur.com/4XICF.png)](https://redcircle.com/shows/sharing-your-stories)|


License
--------

    Copyright 2019-2020 fanmixco, Inc.

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.
