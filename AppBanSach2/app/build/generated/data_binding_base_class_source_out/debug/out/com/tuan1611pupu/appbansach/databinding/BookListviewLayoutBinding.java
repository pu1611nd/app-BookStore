// Generated by view binder compiler. Do not edit!
package com.tuan1611pupu.appbansach.databinding;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import android.widget.TextView;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.viewbinding.ViewBinding;
import androidx.viewbinding.ViewBindings;
import com.tuan1611pupu.appbansach.R;
import java.lang.NullPointerException;
import java.lang.Override;
import java.lang.String;

public final class BookListviewLayoutBinding implements ViewBinding {
  @NonNull
  private final RelativeLayout rootView;

  @NonNull
  public final Button lvBtnActive;

  @NonNull
  public final Button lvBtnEdit;

  @NonNull
  public final ImageView lvImg;

  @NonNull
  public final TextView lvTxtActive;

  @NonNull
  public final TextView lvTxtAuthor;

  @NonNull
  public final TextView lvTxtPrice;

  @NonNull
  public final TextView lvTxtTitle;

  private BookListviewLayoutBinding(@NonNull RelativeLayout rootView, @NonNull Button lvBtnActive,
      @NonNull Button lvBtnEdit, @NonNull ImageView lvImg, @NonNull TextView lvTxtActive,
      @NonNull TextView lvTxtAuthor, @NonNull TextView lvTxtPrice, @NonNull TextView lvTxtTitle) {
    this.rootView = rootView;
    this.lvBtnActive = lvBtnActive;
    this.lvBtnEdit = lvBtnEdit;
    this.lvImg = lvImg;
    this.lvTxtActive = lvTxtActive;
    this.lvTxtAuthor = lvTxtAuthor;
    this.lvTxtPrice = lvTxtPrice;
    this.lvTxtTitle = lvTxtTitle;
  }

  @Override
  @NonNull
  public RelativeLayout getRoot() {
    return rootView;
  }

  @NonNull
  public static BookListviewLayoutBinding inflate(@NonNull LayoutInflater inflater) {
    return inflate(inflater, null, false);
  }

  @NonNull
  public static BookListviewLayoutBinding inflate(@NonNull LayoutInflater inflater,
      @Nullable ViewGroup parent, boolean attachToParent) {
    View root = inflater.inflate(R.layout.book_listview_layout, parent, false);
    if (attachToParent) {
      parent.addView(root);
    }
    return bind(root);
  }

  @NonNull
  public static BookListviewLayoutBinding bind(@NonNull View rootView) {
    // The body of this method is generated in a way you would not otherwise write.
    // This is done to optimize the compiled bytecode for size and performance.
    int id;
    missingId: {
      id = R.id.lv_btn_active;
      Button lvBtnActive = ViewBindings.findChildViewById(rootView, id);
      if (lvBtnActive == null) {
        break missingId;
      }

      id = R.id.lv_btn_edit;
      Button lvBtnEdit = ViewBindings.findChildViewById(rootView, id);
      if (lvBtnEdit == null) {
        break missingId;
      }

      id = R.id.lv_img;
      ImageView lvImg = ViewBindings.findChildViewById(rootView, id);
      if (lvImg == null) {
        break missingId;
      }

      id = R.id.lv_txt_active;
      TextView lvTxtActive = ViewBindings.findChildViewById(rootView, id);
      if (lvTxtActive == null) {
        break missingId;
      }

      id = R.id.lv_txt_author;
      TextView lvTxtAuthor = ViewBindings.findChildViewById(rootView, id);
      if (lvTxtAuthor == null) {
        break missingId;
      }

      id = R.id.lv_txt_price;
      TextView lvTxtPrice = ViewBindings.findChildViewById(rootView, id);
      if (lvTxtPrice == null) {
        break missingId;
      }

      id = R.id.lv_txt_title;
      TextView lvTxtTitle = ViewBindings.findChildViewById(rootView, id);
      if (lvTxtTitle == null) {
        break missingId;
      }

      return new BookListviewLayoutBinding((RelativeLayout) rootView, lvBtnActive, lvBtnEdit, lvImg,
          lvTxtActive, lvTxtAuthor, lvTxtPrice, lvTxtTitle);
    }
    String missingId = rootView.getResources().getResourceName(id);
    throw new NullPointerException("Missing required view with ID: ".concat(missingId));
  }
}
