// Generated by view binder compiler. Do not edit!
package com.tuan1611pupu.appbansach.databinding;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ProgressBar;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.widget.LinearLayoutCompat;
import androidx.viewbinding.ViewBinding;
import androidx.viewbinding.ViewBindings;
import com.tuan1611pupu.appbansach.R;
import java.lang.NullPointerException;
import java.lang.Override;
import java.lang.String;

public final class ActivitySignUpBinding implements ViewBinding {
  @NonNull
  private final LinearLayoutCompat rootView;

  @NonNull
  public final Button btnLogin;

  @NonNull
  public final Button btnRegister;

  @NonNull
  public final ProgressBar progressBarRegister;

  @NonNull
  public final EditText txtEmail;

  @NonNull
  public final EditText txtFullname;

  @NonNull
  public final EditText txtPass;

  @NonNull
  public final EditText txtPassComfirm;

  @NonNull
  public final EditText txtUsername;

  private ActivitySignUpBinding(@NonNull LinearLayoutCompat rootView, @NonNull Button btnLogin,
      @NonNull Button btnRegister, @NonNull ProgressBar progressBarRegister,
      @NonNull EditText txtEmail, @NonNull EditText txtFullname, @NonNull EditText txtPass,
      @NonNull EditText txtPassComfirm, @NonNull EditText txtUsername) {
    this.rootView = rootView;
    this.btnLogin = btnLogin;
    this.btnRegister = btnRegister;
    this.progressBarRegister = progressBarRegister;
    this.txtEmail = txtEmail;
    this.txtFullname = txtFullname;
    this.txtPass = txtPass;
    this.txtPassComfirm = txtPassComfirm;
    this.txtUsername = txtUsername;
  }

  @Override
  @NonNull
  public LinearLayoutCompat getRoot() {
    return rootView;
  }

  @NonNull
  public static ActivitySignUpBinding inflate(@NonNull LayoutInflater inflater) {
    return inflate(inflater, null, false);
  }

  @NonNull
  public static ActivitySignUpBinding inflate(@NonNull LayoutInflater inflater,
      @Nullable ViewGroup parent, boolean attachToParent) {
    View root = inflater.inflate(R.layout.activity_sign_up, parent, false);
    if (attachToParent) {
      parent.addView(root);
    }
    return bind(root);
  }

  @NonNull
  public static ActivitySignUpBinding bind(@NonNull View rootView) {
    // The body of this method is generated in a way you would not otherwise write.
    // This is done to optimize the compiled bytecode for size and performance.
    int id;
    missingId: {
      id = R.id.btnLogin;
      Button btnLogin = ViewBindings.findChildViewById(rootView, id);
      if (btnLogin == null) {
        break missingId;
      }

      id = R.id.btnRegister;
      Button btnRegister = ViewBindings.findChildViewById(rootView, id);
      if (btnRegister == null) {
        break missingId;
      }

      id = R.id.progressBarRegister;
      ProgressBar progressBarRegister = ViewBindings.findChildViewById(rootView, id);
      if (progressBarRegister == null) {
        break missingId;
      }

      id = R.id.txtEmail;
      EditText txtEmail = ViewBindings.findChildViewById(rootView, id);
      if (txtEmail == null) {
        break missingId;
      }

      id = R.id.txtFullname;
      EditText txtFullname = ViewBindings.findChildViewById(rootView, id);
      if (txtFullname == null) {
        break missingId;
      }

      id = R.id.txtPass;
      EditText txtPass = ViewBindings.findChildViewById(rootView, id);
      if (txtPass == null) {
        break missingId;
      }

      id = R.id.txtPassComfirm;
      EditText txtPassComfirm = ViewBindings.findChildViewById(rootView, id);
      if (txtPassComfirm == null) {
        break missingId;
      }

      id = R.id.txtUsername;
      EditText txtUsername = ViewBindings.findChildViewById(rootView, id);
      if (txtUsername == null) {
        break missingId;
      }

      return new ActivitySignUpBinding((LinearLayoutCompat) rootView, btnLogin, btnRegister,
          progressBarRegister, txtEmail, txtFullname, txtPass, txtPassComfirm, txtUsername);
    }
    String missingId = rootView.getResources().getResourceName(id);
    throw new NullPointerException("Missing required view with ID: ".concat(missingId));
  }
}