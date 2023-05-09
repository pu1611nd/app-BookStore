// Generated by view binder compiler. Do not edit!
package com.tuan1611pupu.appbansach.databinding;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.cardview.widget.CardView;
import androidx.viewbinding.ViewBinding;
import androidx.viewbinding.ViewBindings;
import com.tuan1611pupu.appbansach.R;
import java.lang.NullPointerException;
import java.lang.Override;
import java.lang.String;

public final class ItemBookBinding implements ViewBinding {
  @NonNull
  private final CardView rootView;

  @NonNull
  public final ImageView ivSach;

  @NonNull
  public final TextView tvGia;

  @NonNull
  public final TextView tvTenSach;

  private ItemBookBinding(@NonNull CardView rootView, @NonNull ImageView ivSach,
      @NonNull TextView tvGia, @NonNull TextView tvTenSach) {
    this.rootView = rootView;
    this.ivSach = ivSach;
    this.tvGia = tvGia;
    this.tvTenSach = tvTenSach;
  }

  @Override
  @NonNull
  public CardView getRoot() {
    return rootView;
  }

  @NonNull
  public static ItemBookBinding inflate(@NonNull LayoutInflater inflater) {
    return inflate(inflater, null, false);
  }

  @NonNull
  public static ItemBookBinding inflate(@NonNull LayoutInflater inflater,
      @Nullable ViewGroup parent, boolean attachToParent) {
    View root = inflater.inflate(R.layout.item_book, parent, false);
    if (attachToParent) {
      parent.addView(root);
    }
    return bind(root);
  }

  @NonNull
  public static ItemBookBinding bind(@NonNull View rootView) {
    // The body of this method is generated in a way you would not otherwise write.
    // This is done to optimize the compiled bytecode for size and performance.
    int id;
    missingId: {
      id = R.id.ivSach;
      ImageView ivSach = ViewBindings.findChildViewById(rootView, id);
      if (ivSach == null) {
        break missingId;
      }

      id = R.id.tvGia;
      TextView tvGia = ViewBindings.findChildViewById(rootView, id);
      if (tvGia == null) {
        break missingId;
      }

      id = R.id.tvTenSach;
      TextView tvTenSach = ViewBindings.findChildViewById(rootView, id);
      if (tvTenSach == null) {
        break missingId;
      }

      return new ItemBookBinding((CardView) rootView, ivSach, tvGia, tvTenSach);
    }
    String missingId = rootView.getResources().getResourceName(id);
    throw new NullPointerException("Missing required view with ID: ".concat(missingId));
  }
}