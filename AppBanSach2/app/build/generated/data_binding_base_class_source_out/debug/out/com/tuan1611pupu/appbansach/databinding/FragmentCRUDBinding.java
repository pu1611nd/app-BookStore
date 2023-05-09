// Generated by view binder compiler. Do not edit!
package com.tuan1611pupu.appbansach.databinding;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.ScrollView;
import android.widget.Spinner;
import android.widget.Switch;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.viewbinding.ViewBinding;
import androidx.viewbinding.ViewBindings;
import com.tuan1611pupu.appbansach.R;
import java.lang.NullPointerException;
import java.lang.Override;
import java.lang.String;

public final class FragmentCRUDBinding implements ViewBinding {
  @NonNull
  private final ScrollView rootView;

  @NonNull
  public final EditText crudAuthor;

  @NonNull
  public final Button crudBtnAdd;

  @NonNull
  public final Button crudBtnImg;

  @NonNull
  public final Spinner crudCategorys;

  @NonNull
  public final EditText crudDes;

  @NonNull
  public final ImageView crudImg;

  @NonNull
  public final EditText crudInStock;

  @NonNull
  public final EditText crudPrice;

  @NonNull
  public final ScrollView crudScrollview;

  @NonNull
  public final Switch crudSwActive;

  @NonNull
  public final EditText crudTitle;

  @NonNull
  public final EditText crudYear;

  private FragmentCRUDBinding(@NonNull ScrollView rootView, @NonNull EditText crudAuthor,
      @NonNull Button crudBtnAdd, @NonNull Button crudBtnImg, @NonNull Spinner crudCategorys,
      @NonNull EditText crudDes, @NonNull ImageView crudImg, @NonNull EditText crudInStock,
      @NonNull EditText crudPrice, @NonNull ScrollView crudScrollview, @NonNull Switch crudSwActive,
      @NonNull EditText crudTitle, @NonNull EditText crudYear) {
    this.rootView = rootView;
    this.crudAuthor = crudAuthor;
    this.crudBtnAdd = crudBtnAdd;
    this.crudBtnImg = crudBtnImg;
    this.crudCategorys = crudCategorys;
    this.crudDes = crudDes;
    this.crudImg = crudImg;
    this.crudInStock = crudInStock;
    this.crudPrice = crudPrice;
    this.crudScrollview = crudScrollview;
    this.crudSwActive = crudSwActive;
    this.crudTitle = crudTitle;
    this.crudYear = crudYear;
  }

  @Override
  @NonNull
  public ScrollView getRoot() {
    return rootView;
  }

  @NonNull
  public static FragmentCRUDBinding inflate(@NonNull LayoutInflater inflater) {
    return inflate(inflater, null, false);
  }

  @NonNull
  public static FragmentCRUDBinding inflate(@NonNull LayoutInflater inflater,
      @Nullable ViewGroup parent, boolean attachToParent) {
    View root = inflater.inflate(R.layout.fragment_c_r_u_d, parent, false);
    if (attachToParent) {
      parent.addView(root);
    }
    return bind(root);
  }

  @NonNull
  public static FragmentCRUDBinding bind(@NonNull View rootView) {
    // The body of this method is generated in a way you would not otherwise write.
    // This is done to optimize the compiled bytecode for size and performance.
    int id;
    missingId: {
      id = R.id.crud_author;
      EditText crudAuthor = ViewBindings.findChildViewById(rootView, id);
      if (crudAuthor == null) {
        break missingId;
      }

      id = R.id.crud_btn_add;
      Button crudBtnAdd = ViewBindings.findChildViewById(rootView, id);
      if (crudBtnAdd == null) {
        break missingId;
      }

      id = R.id.crud_btn_img;
      Button crudBtnImg = ViewBindings.findChildViewById(rootView, id);
      if (crudBtnImg == null) {
        break missingId;
      }

      id = R.id.crud_categorys;
      Spinner crudCategorys = ViewBindings.findChildViewById(rootView, id);
      if (crudCategorys == null) {
        break missingId;
      }

      id = R.id.crud_des;
      EditText crudDes = ViewBindings.findChildViewById(rootView, id);
      if (crudDes == null) {
        break missingId;
      }

      id = R.id.crud_img;
      ImageView crudImg = ViewBindings.findChildViewById(rootView, id);
      if (crudImg == null) {
        break missingId;
      }

      id = R.id.crud_in_stock;
      EditText crudInStock = ViewBindings.findChildViewById(rootView, id);
      if (crudInStock == null) {
        break missingId;
      }

      id = R.id.crud_price;
      EditText crudPrice = ViewBindings.findChildViewById(rootView, id);
      if (crudPrice == null) {
        break missingId;
      }

      ScrollView crudScrollview = (ScrollView) rootView;

      id = R.id.crud_sw_active;
      Switch crudSwActive = ViewBindings.findChildViewById(rootView, id);
      if (crudSwActive == null) {
        break missingId;
      }

      id = R.id.crud_title;
      EditText crudTitle = ViewBindings.findChildViewById(rootView, id);
      if (crudTitle == null) {
        break missingId;
      }

      id = R.id.crud_year;
      EditText crudYear = ViewBindings.findChildViewById(rootView, id);
      if (crudYear == null) {
        break missingId;
      }

      return new FragmentCRUDBinding((ScrollView) rootView, crudAuthor, crudBtnAdd, crudBtnImg,
          crudCategorys, crudDes, crudImg, crudInStock, crudPrice, crudScrollview, crudSwActive,
          crudTitle, crudYear);
    }
    String missingId = rootView.getResources().getResourceName(id);
    throw new NullPointerException("Missing required view with ID: ".concat(missingId));
  }
}
