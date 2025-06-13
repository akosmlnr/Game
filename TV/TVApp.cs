using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000197 RID: 407
	public class TVApp : MonoBehaviour
	{
		// Token: 0x060020A5 RID: 8357 RVA: 0x000D9064 File Offset: 0x000D7264
		// Note: this type is marked as 'beforefieldinit'.
		static TVApp()
		{
			Il2CppClassPointerStore<TVApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "TVApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVApp>.NativeClassPtr);
			TVApp.NativeFieldInfoPtr_SCALE_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "SCALE_MIN");
			TVApp.NativeFieldInfoPtr_SCALE_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "SCALE_MAX");
			TVApp.NativeFieldInfoPtr_LERP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "LERP_TIME");
			TVApp.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "<IsOpen>k__BackingField");
			TVApp.NativeFieldInfoPtr_CanClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "CanClose");
			TVApp.NativeFieldInfoPtr_AppName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "AppName");
			TVApp.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "Icon");
			TVApp.NativeFieldInfoPtr_Pauseable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "Pauseable");
			TVApp.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "Canvas");
			TVApp.NativeFieldInfoPtr_PreviousScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "PreviousScreen");
			TVApp.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "CanvasGroup");
			TVApp.NativeFieldInfoPtr_PauseScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "PauseScreen");
			TVApp.NativeFieldInfoPtr_lerpCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "lerpCoroutine");
			TVApp.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666979);
			TVApp.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666980);
			TVApp.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666981);
			TVApp.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666982);
			TVApp.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666983);
			TVApp.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666984);
			TVApp.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666985);
			TVApp.NativeMethodInfoPtr_Resume_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666986);
			TVApp.NativeMethodInfoPtr_Lerp_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666987);
			TVApp.NativeMethodInfoPtr_ActiveMinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666988);
			TVApp.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666989);
			TVApp.NativeMethodInfoPtr_TryPause_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666990);
			TVApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666991);
			TVApp.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666992);
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x060020A6 RID: 8358 RVA: 0x000D92B0 File Offset: 0x000D74B0
		// (set) Token: 0x060020A7 RID: 8359 RVA: 0x000D92EC File Offset: 0x000D74EC
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TVApp.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x000D932C File Offset: 0x000D752C
		public unsafe bool IsPaused
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 112239, RefRangeEnd = 112246, XrefRangeStart = 112235, XrefRangeEnd = 112239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TVApp.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x000D9368 File Offset: 0x000D7568
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 112258, RefRangeEnd = 112261, XrefRangeStart = 112246, XrefRangeEnd = 112258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVApp.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x000D93A4 File Offset: 0x000D75A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112261, XrefRangeEnd = 112271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x000D93D8 File Offset: 0x000D75D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 112303, RefRangeEnd = 112305, XrefRangeStart = 112271, XrefRangeEnd = 112303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVApp.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x000D9414 File Offset: 0x000D7614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112329, RefRangeEnd = 112330, XrefRangeStart = 112305, XrefRangeEnd = 112329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVApp.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x000D9450 File Offset: 0x000D7650
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVApp.NativeMethodInfoPtr_Resume_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x000D948C File Offset: 0x000D768C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 112346, RefRangeEnd = 112348, XrefRangeStart = 112330, XrefRangeEnd = 112346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Lerp(float endScale, float endAlpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref endScale;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref endAlpha;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.NativeMethodInfoPtr_Lerp_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x000D94D8 File Offset: 0x000D76D8
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVApp.NativeMethodInfoPtr_ActiveMinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x000D9514 File Offset: 0x000D7714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112348, XrefRangeEnd = 112353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x000D9558 File Offset: 0x000D7758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112353, XrefRangeEnd = 112355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TryPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVApp.NativeMethodInfoPtr_TryPause_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x000D9594 File Offset: 0x000D7794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112355, XrefRangeEnd = 112356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TVApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVApp>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x000D95D0 File Offset: 0x000D77D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112356, XrefRangeEnd = 112361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_Single_Single_PDM_0(float endScale, float endAlpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref endScale;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref endAlpha;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x00012491 File Offset: 0x00010691
		public TVApp(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x000D962C File Offset: 0x000D782C
		// (set) Token: 0x060020B6 RID: 8374 RVA: 0x0001249A File Offset: 0x0001069A
		public unsafe static float SCALE_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TVApp.NativeFieldInfoPtr_SCALE_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TVApp.NativeFieldInfoPtr_SCALE_MIN, (void*)(&value));
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x060020B7 RID: 8375 RVA: 0x000D9648 File Offset: 0x000D7848
		// (set) Token: 0x060020B8 RID: 8376 RVA: 0x000124A8 File Offset: 0x000106A8
		public unsafe static float SCALE_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TVApp.NativeFieldInfoPtr_SCALE_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TVApp.NativeFieldInfoPtr_SCALE_MAX, (void*)(&value));
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x060020B9 RID: 8377 RVA: 0x000D9664 File Offset: 0x000D7864
		// (set) Token: 0x060020BA RID: 8378 RVA: 0x000124B6 File Offset: 0x000106B6
		public unsafe static float LERP_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TVApp.NativeFieldInfoPtr_LERP_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TVApp.NativeFieldInfoPtr_LERP_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x000D9680 File Offset: 0x000D7880
		// (set) Token: 0x060020BC RID: 8380 RVA: 0x000124C4 File Offset: 0x000106C4
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x060020BD RID: 8381 RVA: 0x000D96A8 File Offset: 0x000D78A8
		// (set) Token: 0x060020BE RID: 8382 RVA: 0x000124DF File Offset: 0x000106DF
		public unsafe bool CanClose
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_CanClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_CanClose)) = value;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x060020BF RID: 8383 RVA: 0x000D96D0 File Offset: 0x000D78D0
		// (set) Token: 0x060020C0 RID: 8384 RVA: 0x000124FA File Offset: 0x000106FA
		public unsafe string AppName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_AppName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_AppName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x060020C1 RID: 8385 RVA: 0x000D96F8 File Offset: 0x000D78F8
		// (set) Token: 0x060020C2 RID: 8386 RVA: 0x00012519 File Offset: 0x00010719
		public unsafe Sprite Icon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_Icon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x060020C3 RID: 8387 RVA: 0x000D9728 File Offset: 0x000D7928
		// (set) Token: 0x060020C4 RID: 8388 RVA: 0x00012538 File Offset: 0x00010738
		public unsafe bool Pauseable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_Pauseable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_Pauseable)) = value;
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x060020C5 RID: 8389 RVA: 0x000D9750 File Offset: 0x000D7950
		// (set) Token: 0x060020C6 RID: 8390 RVA: 0x00012553 File Offset: 0x00010753
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x000D9780 File Offset: 0x000D7980
		// (set) Token: 0x060020C8 RID: 8392 RVA: 0x00012572 File Offset: 0x00010772
		public unsafe TVApp PreviousScreen
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_PreviousScreen);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVApp>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_PreviousScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x060020C9 RID: 8393 RVA: 0x000D97B0 File Offset: 0x000D79B0
		// (set) Token: 0x060020CA RID: 8394 RVA: 0x00012591 File Offset: 0x00010791
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_CanvasGroup);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x060020CB RID: 8395 RVA: 0x000D97E0 File Offset: 0x000D79E0
		// (set) Token: 0x060020CC RID: 8396 RVA: 0x000125B0 File Offset: 0x000107B0
		public unsafe TVPauseScreen PauseScreen
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_PauseScreen);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVPauseScreen>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_PauseScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x060020CD RID: 8397 RVA: 0x000D9810 File Offset: 0x000D7A10
		// (set) Token: 0x060020CE RID: 8398 RVA: 0x000125CF File Offset: 0x000107CF
		public unsafe Coroutine lerpCoroutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_lerpCoroutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_lerpCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015A4 RID: 5540
		private static readonly System.IntPtr NativeFieldInfoPtr_SCALE_MIN;

		// Token: 0x040015A5 RID: 5541
		private static readonly System.IntPtr NativeFieldInfoPtr_SCALE_MAX;

		// Token: 0x040015A6 RID: 5542
		private static readonly System.IntPtr NativeFieldInfoPtr_LERP_TIME;

		// Token: 0x040015A7 RID: 5543
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040015A8 RID: 5544
		private static readonly System.IntPtr NativeFieldInfoPtr_CanClose;

		// Token: 0x040015A9 RID: 5545
		private static readonly System.IntPtr NativeFieldInfoPtr_AppName;

		// Token: 0x040015AA RID: 5546
		private static readonly System.IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x040015AB RID: 5547
		private static readonly System.IntPtr NativeFieldInfoPtr_Pauseable;

		// Token: 0x040015AC RID: 5548
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040015AD RID: 5549
		private static readonly System.IntPtr NativeFieldInfoPtr_PreviousScreen;

		// Token: 0x040015AE RID: 5550
		private static readonly System.IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x040015AF RID: 5551
		private static readonly System.IntPtr NativeFieldInfoPtr_PauseScreen;

		// Token: 0x040015B0 RID: 5552
		private static readonly System.IntPtr NativeFieldInfoPtr_lerpCoroutine;

		// Token: 0x040015B1 RID: 5553
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040015B2 RID: 5554
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x040015B3 RID: 5555
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0;

		// Token: 0x040015B4 RID: 5556
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040015B5 RID: 5557
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040015B6 RID: 5558
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0;

		// Token: 0x040015B7 RID: 5559
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x040015B8 RID: 5560
		private static readonly System.IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_New_Void_0;

		// Token: 0x040015B9 RID: 5561
		private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Private_Void_Single_Single_0;

		// Token: 0x040015BA RID: 5562
		private static readonly System.IntPtr NativeMethodInfoPtr_ActiveMinPass_Protected_Virtual_New_Void_0;

		// Token: 0x040015BB RID: 5563
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040015BC RID: 5564
		private static readonly System.IntPtr NativeMethodInfoPtr_TryPause_Protected_Virtual_New_Void_0;

		// Token: 0x040015BD RID: 5565
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040015BE RID: 5566
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_Single_Single_PDM_0;

		// Token: 0x020008E8 RID: 2280
		[ObfuscatedName("ScheduleOne.TV.TVApp+<<Lerp>g__Lerp|23_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C76B RID: 51051 RVA: 0x0030D3DC File Offset: 0x0030B5DC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique()
			{
				Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "<<Lerp>g__Lerp|23_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr);
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, "<>1__state");
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, "<>2__current");
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, "<>4__this");
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr_endScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, "endScale");
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr_endAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, "endAlpha");
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__startScale_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, "<startScale>5__2");
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__startAlpha_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, "<startAlpha>5__3");
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__lerpTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, "<lerpTime>5__4");
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, "<i>5__5");
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, 100666993);
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, 100666994);
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, 100666995);
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, 100666996);
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, 100666997);
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, 100666998);
			}

			// Token: 0x0600C76C RID: 51052 RVA: 0x0030D534 File Offset: 0x0030B734
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C76D RID: 51053 RVA: 0x0030D57C File Offset: 0x0030B77C
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C76E RID: 51054 RVA: 0x0030D5B0 File Offset: 0x0030B7B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112193, XrefRangeEnd = 112230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003DFF RID: 15871
			// (get) Token: 0x0600C76F RID: 51055 RVA: 0x0030D5EC File Offset: 0x0030B7EC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C770 RID: 51056 RVA: 0x0030D62C File Offset: 0x0030B82C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112230, XrefRangeEnd = 112235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003E00 RID: 15872
			// (get) Token: 0x0600C771 RID: 51057 RVA: 0x0030D660 File Offset: 0x0030B860
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C772 RID: 51058 RVA: 0x00060AC2 File Offset: 0x0005ECC2
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DF6 RID: 15862
			// (get) Token: 0x0600C773 RID: 51059 RVA: 0x0030D6A0 File Offset: 0x0030B8A0
			// (set) Token: 0x0600C774 RID: 51060 RVA: 0x00060ACB File Offset: 0x0005ECCB
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003DF7 RID: 15863
			// (get) Token: 0x0600C775 RID: 51061 RVA: 0x0030D6C8 File Offset: 0x0030B8C8
			// (set) Token: 0x0600C776 RID: 51062 RVA: 0x00060AE6 File Offset: 0x0005ECE6
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DF8 RID: 15864
			// (get) Token: 0x0600C777 RID: 51063 RVA: 0x0030D6F8 File Offset: 0x0030B8F8
			// (set) Token: 0x0600C778 RID: 51064 RVA: 0x00060B05 File Offset: 0x0005ED05
			public unsafe TVApp __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVApp>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DF9 RID: 15865
			// (get) Token: 0x0600C779 RID: 51065 RVA: 0x0030D728 File Offset: 0x0030B928
			// (set) Token: 0x0600C77A RID: 51066 RVA: 0x00060B24 File Offset: 0x0005ED24
			public unsafe float endScale
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr_endScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr_endScale)) = value;
				}
			}

			// Token: 0x17003DFA RID: 15866
			// (get) Token: 0x0600C77B RID: 51067 RVA: 0x0030D750 File Offset: 0x0030B950
			// (set) Token: 0x0600C77C RID: 51068 RVA: 0x00060B3F File Offset: 0x0005ED3F
			public unsafe float endAlpha
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr_endAlpha);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr_endAlpha)) = value;
				}
			}

			// Token: 0x17003DFB RID: 15867
			// (get) Token: 0x0600C77D RID: 51069 RVA: 0x0030D778 File Offset: 0x0030B978
			// (set) Token: 0x0600C77E RID: 51070 RVA: 0x00060B5A File Offset: 0x0005ED5A
			public unsafe float _startScale_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__startScale_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__startScale_5__2)) = value;
				}
			}

			// Token: 0x17003DFC RID: 15868
			// (get) Token: 0x0600C77F RID: 51071 RVA: 0x0030D7A0 File Offset: 0x0030B9A0
			// (set) Token: 0x0600C780 RID: 51072 RVA: 0x00060B75 File Offset: 0x0005ED75
			public unsafe float _startAlpha_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__startAlpha_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__startAlpha_5__3)) = value;
				}
			}

			// Token: 0x17003DFD RID: 15869
			// (get) Token: 0x0600C781 RID: 51073 RVA: 0x0030D7C8 File Offset: 0x0030B9C8
			// (set) Token: 0x0600C782 RID: 51074 RVA: 0x00060B90 File Offset: 0x0005ED90
			public unsafe float _lerpTime_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__lerpTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__lerpTime_5__4)) = value;
				}
			}

			// Token: 0x17003DFE RID: 15870
			// (get) Token: 0x0600C783 RID: 51075 RVA: 0x0030D7F0 File Offset: 0x0030B9F0
			// (set) Token: 0x0600C784 RID: 51076 RVA: 0x00060BAB File Offset: 0x0005EDAB
			public unsafe float _i_5__5
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x04008761 RID: 34657
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008762 RID: 34658
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008763 RID: 34659
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008764 RID: 34660
			private static readonly System.IntPtr NativeFieldInfoPtr_endScale;

			// Token: 0x04008765 RID: 34661
			private static readonly System.IntPtr NativeFieldInfoPtr_endAlpha;

			// Token: 0x04008766 RID: 34662
			private static readonly System.IntPtr NativeFieldInfoPtr__startScale_5__2;

			// Token: 0x04008767 RID: 34663
			private static readonly System.IntPtr NativeFieldInfoPtr__startAlpha_5__3;

			// Token: 0x04008768 RID: 34664
			private static readonly System.IntPtr NativeFieldInfoPtr__lerpTime_5__4;

			// Token: 0x04008769 RID: 34665
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x0400876A RID: 34666
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400876B RID: 34667
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400876C RID: 34668
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400876D RID: 34669
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400876E RID: 34670
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400876F RID: 34671
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
