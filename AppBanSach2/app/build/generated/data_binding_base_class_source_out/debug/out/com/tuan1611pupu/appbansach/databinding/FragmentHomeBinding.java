// Generated by view binder compiler. Do not edit!
package com.tuan1611pupu.appbansach.databinding;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.FrameLayout;
import android.widget.LinearLayout;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.ViewFlipper;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.constraintlayout.utils.widget.ImageFilterButton;
import androidx.recyclerview.widget.RecyclerView;
import androidx.viewbinding.ViewBinding;
import androidx.viewbinding.ViewBindings;
import com.tuan1611pupu.appbansach.R;
import java.lang.NullPointerException;
import java.lang.Override;
import java.lang.String;

public final class FragmentHomeBinding implements ViewBinding {
  @NonNull
  private final FrameLayout rootView;

  @NonNull
  public final ImageFilterButton btnBack1;

  @NonNull
  public final ImageFilterButton btnForward1;

  @NonNull
  public final LinearLayout linearBook;

  @NonNull
  public final Spinner locTheoTheLoai;

  @NonNull
  public final RecyclerView rcListBook;

  @NonNull
  public final RecyclerView recyclerViewBook;

  @NonNull
  public final TextView tvPage1;

  @NonNull
  public final TextView tvPages1;

  @NonNull
  public final ViewFlipper viewFlipper;

  private FragmentHomeBinding(@NonNull FrameLayout rootView, @NonNull ImageFilterButton btnBack1,
      @NonNull ImageFilterButton btnForward1, @NonNull LinearLayout linearBook,
      @NonNull Spinner locTheoTheLoai, @NonNull RecyclerView rcListBook,
      @NonNull RecyclerView recyclerViewBook, @NonNull TextView tvPage1, @NonNull TextView tvPages1,
      @NonNull ViewFlipper viewFlipper) {
    this.rootView = rootView;
    this.btnBack1 = btnBack1;
    this.btnForward1 = btnForward1;
    this.linearBook = linearBook;
    this.locTheoTheLoai = locTheoTheLoai;
    this.rcListBook = rcListBook;
    this.recyclerViewBook = recyclerViewBook;
    this.tvPage1 = tvPage1;
    this.tvPages1 = tvPages1;
    this.viewFlipper = viewFlipper;
  }

  @Override
  @NonNull
  public FrameLayout getRoot() {
    return rootView;
  }

  @NonNull
  public static FragmentHomeBinding inflate(@NonNull LayoutInflater inflater) {
    return inflate(inflater, null, false);
  }

  @NonNull
  public static FragmentHomeBinding inflate(@NonNull LayoutInflater inflater,
      @Nullable ViewGroup parent, boolean attachToParent) {
    View root = inflater.inflate(R.layout.fragment_home, parent, false);
    if (attachToParent) {
      parent.addView(root);
    }
    return bind(root);
  }

  @NonNull
  public static FragmentHomeBinding bind(@NonNull View rootView) {
    // The body of this method is generated in a way you would not otherwise write.
    // This is done to optimize the compiled bytecode for size and performance.
    int id;
    missingId: {
      id = R.id.btn_back1;
      ImageFilterButton btnBack1 = ViewBindings.findChildViewById(rootView, id);
      if (btnBack1 == null) {
        break missingId;
      }

      id = R.id.btn_forward1;
      ImageFilterButton btnForward1 = ViewBindings.findChildViewById(rootView, id);
      if (btnForward1 == null) {
        break missingId;
      }

      id = R.id.linear_book;
      LinearLayout linearBook = ViewBindings.findChildViewById(rootView, id);
      if (linearBook == null) {
        break missingId;
      }

      id = R.id.locTheoTheLoai;
      Spinner locTheoTheLoai = ViewBindings.findChildViewById(rootView, id);
      if (locTheoTheLoai == null) {
        break missingId;
      }

      id = R.id.rcListBook;
      RecyclerView rcListBook = ViewBindings.findChildViewById(rootView, id);
      if (rcListBook == null) {
        break missingId;
      }

      id = R.id.recyclerViewBook;
      RecyclerView recyclerViewBook = ViewBindings.findChildViewById(rootView, id);
      if (recyclerViewBook == null) {
        break missingId;
      }

      id = R.id.tv_page1;
      TextView tvPage1 = ViewBindings.findChildViewById(rootView, id);
      if (tvPage1 == null) {
        break missingId;
      }

      id = R.id.tv_pages1;
      TextView tvPages1 = ViewBindings.findChildViewById(rootView, id);
      if (tvPages1 == null) {
        break missingId;
      }

      id = R.id.viewFlipper;
      ViewFlipper viewFlipper = ViewBindings.findChildViewById(rootView, id);
      if (viewFlipper == null) {
        break missingId;
      }

      return new FragmentHomeBinding((FrameLayout) rootView, btnBack1, btnForward1, linearBook,
          locTheoTheLoai, rcListBook, recyclerViewBook, tvPage1, tvPages1, viewFlipper);
    }
    String missingId = rootView.getResources().getResourceName(id);
    throw new NullPointerException("Missing required view with ID: ".concat(missingId));
  }
}
