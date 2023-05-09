// Generated by view binder compiler. Do not edit!
package com.tuan1611pupu.appbansach.databinding;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.TextView;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.recyclerview.widget.RecyclerView;
import androidx.viewbinding.ViewBinding;
import androidx.viewbinding.ViewBindings;
import com.tuan1611pupu.appbansach.R;
import java.lang.NullPointerException;
import java.lang.Override;
import java.lang.String;

public final class FragmentCartBinding implements ViewBinding {
  @NonNull
  private final LinearLayout rootView;

  @NonNull
  public final Button cartBtnBack;

  @NonNull
  public final Button cartBtnCheckOut;

  @NonNull
  public final RecyclerView rcListCartItem;

  @NonNull
  public final TextView textView6;

  @NonNull
  public final TextView txtTongGioHang;

  private FragmentCartBinding(@NonNull LinearLayout rootView, @NonNull Button cartBtnBack,
      @NonNull Button cartBtnCheckOut, @NonNull RecyclerView rcListCartItem,
      @NonNull TextView textView6, @NonNull TextView txtTongGioHang) {
    this.rootView = rootView;
    this.cartBtnBack = cartBtnBack;
    this.cartBtnCheckOut = cartBtnCheckOut;
    this.rcListCartItem = rcListCartItem;
    this.textView6 = textView6;
    this.txtTongGioHang = txtTongGioHang;
  }

  @Override
  @NonNull
  public LinearLayout getRoot() {
    return rootView;
  }

  @NonNull
  public static FragmentCartBinding inflate(@NonNull LayoutInflater inflater) {
    return inflate(inflater, null, false);
  }

  @NonNull
  public static FragmentCartBinding inflate(@NonNull LayoutInflater inflater,
      @Nullable ViewGroup parent, boolean attachToParent) {
    View root = inflater.inflate(R.layout.fragment_cart, parent, false);
    if (attachToParent) {
      parent.addView(root);
    }
    return bind(root);
  }

  @NonNull
  public static FragmentCartBinding bind(@NonNull View rootView) {
    // The body of this method is generated in a way you would not otherwise write.
    // This is done to optimize the compiled bytecode for size and performance.
    int id;
    missingId: {
      id = R.id.cart_btnBack;
      Button cartBtnBack = ViewBindings.findChildViewById(rootView, id);
      if (cartBtnBack == null) {
        break missingId;
      }

      id = R.id.cart_btnCheckOut;
      Button cartBtnCheckOut = ViewBindings.findChildViewById(rootView, id);
      if (cartBtnCheckOut == null) {
        break missingId;
      }

      id = R.id.rcListCartItem;
      RecyclerView rcListCartItem = ViewBindings.findChildViewById(rootView, id);
      if (rcListCartItem == null) {
        break missingId;
      }

      id = R.id.textView6;
      TextView textView6 = ViewBindings.findChildViewById(rootView, id);
      if (textView6 == null) {
        break missingId;
      }

      id = R.id.txtTongGioHang;
      TextView txtTongGioHang = ViewBindings.findChildViewById(rootView, id);
      if (txtTongGioHang == null) {
        break missingId;
      }

      return new FragmentCartBinding((LinearLayout) rootView, cartBtnBack, cartBtnCheckOut,
          rcListCartItem, textView6, txtTongGioHang);
    }
    String missingId = rootView.getResources().getResourceName(id);
    throw new NullPointerException("Missing required view with ID: ".concat(missingId));
  }
}
