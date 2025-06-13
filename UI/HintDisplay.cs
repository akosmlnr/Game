using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text.RegularExpressions;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000664 RID: 1636
	public class HintDisplay : Singleton<HintDisplay>
	{
		// Token: 0x06008FAF RID: 36783 RVA: 0x002593E0 File Offset: 0x002575E0
		// Note: this type is marked as 'beforefieldinit'.
		static HintDisplay()
		{
			Il2CppClassPointerStore<HintDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "HintDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr);
			HintDisplay.NativeFieldInfoPtr_FadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "FadeTime");
			HintDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "<IsOpen>k__BackingField");
			HintDisplay.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Container");
			HintDisplay.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Label");
			HintDisplay.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Group");
			HintDisplay.NativeFieldInfoPtr_DismissPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "DismissPrompt");
			HintDisplay.NativeFieldInfoPtr_FlashAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "FlashAnim");
			HintDisplay.NativeFieldInfoPtr_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Padding");
			HintDisplay.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Offset");
			HintDisplay.NativeFieldInfoPtr_autoCloseRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "autoCloseRoutine");
			HintDisplay.NativeFieldInfoPtr_fadeRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "fadeRoutine");
			HintDisplay.NativeFieldInfoPtr_hintQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "hintQueue");
			HintDisplay.NativeFieldInfoPtr_timeSinceOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "timeSinceOpened");
			HintDisplay.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100681246);
			HintDisplay.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100681247);
			HintDisplay.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100681248);
			HintDisplay.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100681249);
			HintDisplay.NativeMethodInfoPtr_ShowHint_10s_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100681250);
			HintDisplay.NativeMethodInfoPtr_ShowHint_20s_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100681251);
			HintDisplay.NativeMethodInfoPtr_ShowHint_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100681252);
			HintDisplay.NativeMethodInfoPtr_ShowHint_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100681253);
			HintDisplay.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100681254);
			HintDisplay.NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100681255);
			HintDisplay.NativeMethodInfoPtr_QueueHint_10s_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100681256);
			HintDisplay.NativeMethodInfoPtr_QueueHint_20s_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100681257);
			HintDisplay.NativeMethodInfoPtr_QueueHint_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100681258);
			HintDisplay.NativeMethodInfoPtr_ProcessText_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100681259);
			HintDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100681260);
			HintDisplay.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100681261);
		}

		// Token: 0x17002BAF RID: 11183
		// (get) Token: 0x06008FB0 RID: 36784 RVA: 0x00259654 File Offset: 0x00257854
		// (set) Token: 0x06008FB1 RID: 36785 RVA: 0x00259690 File Offset: 0x00257890
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008FB2 RID: 36786 RVA: 0x002596D0 File Offset: 0x002578D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261884, XrefRangeEnd = 261891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HintDisplay.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FB3 RID: 36787 RVA: 0x0025970C File Offset: 0x0025790C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261891, XrefRangeEnd = 261913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FB4 RID: 36788 RVA: 0x00259740 File Offset: 0x00257940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261913, XrefRangeEnd = 261914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowHint_10s(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_ShowHint_10s_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FB5 RID: 36789 RVA: 0x00259784 File Offset: 0x00257984
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 261915, RefRangeEnd = 261920, XrefRangeStart = 261914, XrefRangeEnd = 261915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowHint_20s(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_ShowHint_20s_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FB6 RID: 36790 RVA: 0x002597C8 File Offset: 0x002579C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261920, XrefRangeEnd = 261921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowHint(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_ShowHint_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FB7 RID: 36791 RVA: 0x0025980C File Offset: 0x00257A0C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 261943, RefRangeEnd = 261949, XrefRangeStart = 261921, XrefRangeEnd = 261943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowHint(string text, float autoCloseTime = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref autoCloseTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_ShowHint_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FB8 RID: 36792 RVA: 0x0025985C File Offset: 0x00257A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261949, XrefRangeEnd = 261950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FB9 RID: 36793 RVA: 0x00259890 File Offset: 0x00257A90
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 261966, RefRangeEnd = 261970, XrefRangeStart = 261950, XrefRangeEnd = 261966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref alpha;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FBA RID: 36794 RVA: 0x002598D0 File Offset: 0x00257AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261970, XrefRangeEnd = 261981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueHint_10s(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_QueueHint_10s_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FBB RID: 36795 RVA: 0x00259914 File Offset: 0x00257B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261981, XrefRangeEnd = 261992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueHint_20s(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_QueueHint_20s_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FBC RID: 36796 RVA: 0x00259958 File Offset: 0x00257B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261992, XrefRangeEnd = 262000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueHint(string message, float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref time;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_QueueHint_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FBD RID: 36797 RVA: 0x002599A8 File Offset: 0x00257BA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262042, RefRangeEnd = 262043, XrefRangeStart = 262000, XrefRangeEnd = 262042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ProcessText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_ProcessText_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06008FBE RID: 36798 RVA: 0x002599F0 File Offset: 0x00257BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262043, XrefRangeEnd = 262053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HintDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008FBF RID: 36799 RVA: 0x00259A2C File Offset: 0x00257C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262053, XrefRangeEnd = 262058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_Single_PDM_0(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref time;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06008FC0 RID: 36800 RVA: 0x00044AEA File Offset: 0x00042CEA
		public HintDisplay(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002BA2 RID: 11170
		// (get) Token: 0x06008FC1 RID: 36801 RVA: 0x00259A78 File Offset: 0x00257C78
		// (set) Token: 0x06008FC2 RID: 36802 RVA: 0x00044AF3 File Offset: 0x00042CF3
		public unsafe static float FadeTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(HintDisplay.NativeFieldInfoPtr_FadeTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HintDisplay.NativeFieldInfoPtr_FadeTime, (void*)(&value));
			}
		}

		// Token: 0x17002BA3 RID: 11171
		// (get) Token: 0x06008FC3 RID: 36803 RVA: 0x00259A94 File Offset: 0x00257C94
		// (set) Token: 0x06008FC4 RID: 36804 RVA: 0x00044B01 File Offset: 0x00042D01
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002BA4 RID: 11172
		// (get) Token: 0x06008FC5 RID: 36805 RVA: 0x00259ABC File Offset: 0x00257CBC
		// (set) Token: 0x06008FC6 RID: 36806 RVA: 0x00044B1C File Offset: 0x00042D1C
		public unsafe RectTransform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BA5 RID: 11173
		// (get) Token: 0x06008FC7 RID: 36807 RVA: 0x00259AEC File Offset: 0x00257CEC
		// (set) Token: 0x06008FC8 RID: 36808 RVA: 0x00044B3B File Offset: 0x00042D3B
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Label);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BA6 RID: 11174
		// (get) Token: 0x06008FC9 RID: 36809 RVA: 0x00259B1C File Offset: 0x00257D1C
		// (set) Token: 0x06008FCA RID: 36810 RVA: 0x00044B5A File Offset: 0x00042D5A
		public unsafe CanvasGroup Group
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Group);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BA7 RID: 11175
		// (get) Token: 0x06008FCB RID: 36811 RVA: 0x00259B4C File Offset: 0x00257D4C
		// (set) Token: 0x06008FCC RID: 36812 RVA: 0x00044B79 File Offset: 0x00042D79
		public unsafe InputPrompt DismissPrompt
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_DismissPrompt);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPrompt>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_DismissPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BA8 RID: 11176
		// (get) Token: 0x06008FCD RID: 36813 RVA: 0x00259B7C File Offset: 0x00257D7C
		// (set) Token: 0x06008FCE RID: 36814 RVA: 0x00044B98 File Offset: 0x00042D98
		public unsafe Animation FlashAnim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_FlashAnim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_FlashAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BA9 RID: 11177
		// (get) Token: 0x06008FCF RID: 36815 RVA: 0x00259BAC File Offset: 0x00257DAC
		// (set) Token: 0x06008FD0 RID: 36816 RVA: 0x00044BB7 File Offset: 0x00042DB7
		public unsafe Vector2 Padding
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Padding)) = value;
			}
		}

		// Token: 0x17002BAA RID: 11178
		// (get) Token: 0x06008FD1 RID: 36817 RVA: 0x00259BD4 File Offset: 0x00257DD4
		// (set) Token: 0x06008FD2 RID: 36818 RVA: 0x00044BD2 File Offset: 0x00042DD2
		public unsafe Vector2 Offset
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Offset)) = value;
			}
		}

		// Token: 0x17002BAB RID: 11179
		// (get) Token: 0x06008FD3 RID: 36819 RVA: 0x00259BFC File Offset: 0x00257DFC
		// (set) Token: 0x06008FD4 RID: 36820 RVA: 0x00044BED File Offset: 0x00042DED
		public unsafe Coroutine autoCloseRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_autoCloseRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_autoCloseRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BAC RID: 11180
		// (get) Token: 0x06008FD5 RID: 36821 RVA: 0x00259C2C File Offset: 0x00257E2C
		// (set) Token: 0x06008FD6 RID: 36822 RVA: 0x00044C0C File Offset: 0x00042E0C
		public unsafe Coroutine fadeRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_fadeRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_fadeRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BAD RID: 11181
		// (get) Token: 0x06008FD7 RID: 36823 RVA: 0x00259C5C File Offset: 0x00257E5C
		// (set) Token: 0x06008FD8 RID: 36824 RVA: 0x00044C2B File Offset: 0x00042E2B
		public unsafe List<HintDisplay.Hint> hintQueue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_hintQueue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<HintDisplay.Hint>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_hintQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BAE RID: 11182
		// (get) Token: 0x06008FD9 RID: 36825 RVA: 0x00259C8C File Offset: 0x00257E8C
		// (set) Token: 0x06008FDA RID: 36826 RVA: 0x00044C4A File Offset: 0x00042E4A
		public unsafe float timeSinceOpened
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_timeSinceOpened);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_timeSinceOpened)) = value;
			}
		}

		// Token: 0x0400615F RID: 24927
		private static readonly System.IntPtr NativeFieldInfoPtr_FadeTime;

		// Token: 0x04006160 RID: 24928
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006161 RID: 24929
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006162 RID: 24930
		private static readonly System.IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04006163 RID: 24931
		private static readonly System.IntPtr NativeFieldInfoPtr_Group;

		// Token: 0x04006164 RID: 24932
		private static readonly System.IntPtr NativeFieldInfoPtr_DismissPrompt;

		// Token: 0x04006165 RID: 24933
		private static readonly System.IntPtr NativeFieldInfoPtr_FlashAnim;

		// Token: 0x04006166 RID: 24934
		private static readonly System.IntPtr NativeFieldInfoPtr_Padding;

		// Token: 0x04006167 RID: 24935
		private static readonly System.IntPtr NativeFieldInfoPtr_Offset;

		// Token: 0x04006168 RID: 24936
		private static readonly System.IntPtr NativeFieldInfoPtr_autoCloseRoutine;

		// Token: 0x04006169 RID: 24937
		private static readonly System.IntPtr NativeFieldInfoPtr_fadeRoutine;

		// Token: 0x0400616A RID: 24938
		private static readonly System.IntPtr NativeFieldInfoPtr_hintQueue;

		// Token: 0x0400616B RID: 24939
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceOpened;

		// Token: 0x0400616C RID: 24940
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400616D RID: 24941
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x0400616E RID: 24942
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400616F RID: 24943
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04006170 RID: 24944
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowHint_10s_Public_Void_String_0;

		// Token: 0x04006171 RID: 24945
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowHint_20s_Public_Void_String_0;

		// Token: 0x04006172 RID: 24946
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowHint_Public_Void_String_0;

		// Token: 0x04006173 RID: 24947
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowHint_Public_Void_String_Single_0;

		// Token: 0x04006174 RID: 24948
		private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

		// Token: 0x04006175 RID: 24949
		private static readonly System.IntPtr NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0;

		// Token: 0x04006176 RID: 24950
		private static readonly System.IntPtr NativeMethodInfoPtr_QueueHint_10s_Public_Void_String_0;

		// Token: 0x04006177 RID: 24951
		private static readonly System.IntPtr NativeMethodInfoPtr_QueueHint_20s_Public_Void_String_0;

		// Token: 0x04006178 RID: 24952
		private static readonly System.IntPtr NativeMethodInfoPtr_QueueHint_Public_Void_String_Single_0;

		// Token: 0x04006179 RID: 24953
		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessText_Private_String_String_0;

		// Token: 0x0400617A RID: 24954
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400617B RID: 24955
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0;

		// Token: 0x02000B73 RID: 2931
		public class Hint : Il2CppSystem.Object
		{
			// Token: 0x0600DCB3 RID: 56499 RVA: 0x00349BA0 File Offset: 0x00347DA0
			// Note: this type is marked as 'beforefieldinit'.
			static Hint()
			{
				Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Hint");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr);
				HintDisplay.Hint.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr, "Text");
				HintDisplay.Hint.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr, "Duration");
				HintDisplay.Hint.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr, 100681262);
			}

			// Token: 0x0600DCB4 RID: 56500 RVA: 0x00349C08 File Offset: 0x00347E08
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 72740, RefRangeEnd = 72741, XrefRangeStart = 72740, XrefRangeEnd = 72741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Hint(string text, float duration) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref duration;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.Hint.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DCB5 RID: 56501 RVA: 0x0006B217 File Offset: 0x00069417
			public Hint(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004418 RID: 17432
			// (get) Token: 0x0600DCB6 RID: 56502 RVA: 0x00349C64 File Offset: 0x00347E64
			// (set) Token: 0x0600DCB7 RID: 56503 RVA: 0x0006B220 File Offset: 0x00069420
			public unsafe string Text
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.Hint.NativeFieldInfoPtr_Text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.Hint.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004419 RID: 17433
			// (get) Token: 0x0600DCB8 RID: 56504 RVA: 0x00349C8C File Offset: 0x00347E8C
			// (set) Token: 0x0600DCB9 RID: 56505 RVA: 0x0006B23F File Offset: 0x0006943F
			public unsafe float Duration
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.Hint.NativeFieldInfoPtr_Duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.Hint.NativeFieldInfoPtr_Duration)) = value;
				}
			}

			// Token: 0x0400946F RID: 37999
			private static readonly System.IntPtr NativeFieldInfoPtr_Text;

			// Token: 0x04009470 RID: 38000
			private static readonly System.IntPtr NativeFieldInfoPtr_Duration;

			// Token: 0x04009471 RID: 38001
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_0;
		}

		// Token: 0x02000B74 RID: 2932
		[ObfuscatedName("ScheduleOne.UI.HintDisplay+<<ShowHint>g__AutoClose|22_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DCBA RID: 56506 RVA: 0x00349CB4 File Offset: 0x00347EB4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique()
			{
				Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "<<ShowHint>g__AutoClose|22_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, "<>1__state");
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, "<>2__current");
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, "time");
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, "<>4__this");
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100681263);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100681264);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100681265);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100681266);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100681267);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100681268);
			}

			// Token: 0x0600DCBB RID: 56507 RVA: 0x00349DA8 File Offset: 0x00347FA8
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DCBC RID: 56508 RVA: 0x00349DF0 File Offset: 0x00347FF0
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DCBD RID: 56509 RVA: 0x00349E24 File Offset: 0x00348024
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261841, XrefRangeEnd = 261846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x1700441E RID: 17438
			// (get) Token: 0x0600DCBE RID: 56510 RVA: 0x00349E60 File Offset: 0x00348060
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DCBF RID: 56511 RVA: 0x00349EA0 File Offset: 0x003480A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261846, XrefRangeEnd = 261851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x1700441F RID: 17439
			// (get) Token: 0x0600DCC0 RID: 56512 RVA: 0x00349ED4 File Offset: 0x003480D4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DCC1 RID: 56513 RVA: 0x0006B25A File Offset: 0x0006945A
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700441A RID: 17434
			// (get) Token: 0x0600DCC2 RID: 56514 RVA: 0x00349F14 File Offset: 0x00348114
			// (set) Token: 0x0600DCC3 RID: 56515 RVA: 0x0006B263 File Offset: 0x00069463
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700441B RID: 17435
			// (get) Token: 0x0600DCC4 RID: 56516 RVA: 0x00349F3C File Offset: 0x0034813C
			// (set) Token: 0x0600DCC5 RID: 56517 RVA: 0x0006B27E File Offset: 0x0006947E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700441C RID: 17436
			// (get) Token: 0x0600DCC6 RID: 56518 RVA: 0x00349F6C File Offset: 0x0034816C
			// (set) Token: 0x0600DCC7 RID: 56519 RVA: 0x0006B29D File Offset: 0x0006949D
			public unsafe float time
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x1700441D RID: 17437
			// (get) Token: 0x0600DCC8 RID: 56520 RVA: 0x00349F94 File Offset: 0x00348194
			// (set) Token: 0x0600DCC9 RID: 56521 RVA: 0x0006B2B8 File Offset: 0x000694B8
			public unsafe HintDisplay __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HintDisplay>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009472 RID: 38002
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009473 RID: 38003
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009474 RID: 38004
			private static readonly System.IntPtr NativeFieldInfoPtr_time;

			// Token: 0x04009475 RID: 38005
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009476 RID: 38006
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009477 RID: 38007
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009478 RID: 38008
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009479 RID: 38009
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400947A RID: 38010
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400947B RID: 38011
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B75 RID: 2933
		[ObfuscatedName("ScheduleOne.UI.HintDisplay+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DCCA RID: 56522 RVA: 0x00349FC4 File Offset: 0x003481C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr);
				HintDisplay.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr, "<>9");
				HintDisplay.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr, "<>9__28_0");
				HintDisplay.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr, 100681270);
				HintDisplay.__c.NativeMethodInfoPtr__ProcessText_b__28_0_Internal_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr, 100681271);
			}

			// Token: 0x0600DCCB RID: 56523 RVA: 0x0034A040 File Offset: 0x00348240
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DCCC RID: 56524 RVA: 0x0034A07C File Offset: 0x0034827C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261851, XrefRangeEnd = 261864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ProcessText_b__28_0(Match match)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c.NativeMethodInfoPtr__ProcessText_b__28_0_Internal_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}

			// Token: 0x0600DCCD RID: 56525 RVA: 0x0006B2D7 File Offset: 0x000694D7
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004420 RID: 17440
			// (get) Token: 0x0600DCCE RID: 56526 RVA: 0x0034A0C4 File Offset: 0x003482C4
			// (set) Token: 0x0600DCCF RID: 56527 RVA: 0x0006B2E0 File Offset: 0x000694E0
			public unsafe static HintDisplay.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HintDisplay.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HintDisplay.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HintDisplay.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004421 RID: 17441
			// (get) Token: 0x0600DCD0 RID: 56528 RVA: 0x0034A0EC File Offset: 0x003482EC
			// (set) Token: 0x0600DCD1 RID: 56529 RVA: 0x0006B2F2 File Offset: 0x000694F2
			public unsafe static MatchEvaluator __9__28_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HintDisplay.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchEvaluator>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HintDisplay.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400947C RID: 38012
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400947D RID: 38013
			private static readonly System.IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x0400947E RID: 38014
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400947F RID: 38015
			private static readonly System.IntPtr NativeMethodInfoPtr__ProcessText_b__28_0_Internal_String_Match_0;
		}

		// Token: 0x02000B76 RID: 2934
		[ObfuscatedName("ScheduleOne.UI.HintDisplay+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DCD2 RID: 56530 RVA: 0x0034A114 File Offset: 0x00348314
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr);
				HintDisplay.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr, "<>4__this");
				HintDisplay.__c__DisplayClass24_0.NativeFieldInfoPtr_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr, "alpha");
				HintDisplay.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr, 100681272);
				HintDisplay.__c__DisplayClass24_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr, 100681273);
			}

			// Token: 0x0600DCD3 RID: 56531 RVA: 0x0034A190 File Offset: 0x00348390
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DCD4 RID: 56532 RVA: 0x0034A1CC File Offset: 0x003483CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261879, XrefRangeEnd = 261884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DCD5 RID: 56533 RVA: 0x0006B304 File Offset: 0x00069504
			public __c__DisplayClass24_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004422 RID: 17442
			// (get) Token: 0x0600DCD6 RID: 56534 RVA: 0x0034A20C File Offset: 0x0034840C
			// (set) Token: 0x0600DCD7 RID: 56535 RVA: 0x0006B30D File Offset: 0x0006950D
			public unsafe HintDisplay __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HintDisplay>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004423 RID: 17443
			// (get) Token: 0x0600DCD8 RID: 56536 RVA: 0x0034A23C File Offset: 0x0034843C
			// (set) Token: 0x0600DCD9 RID: 56537 RVA: 0x0006B32C File Offset: 0x0006952C
			public unsafe float alpha
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.NativeFieldInfoPtr_alpha);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.NativeFieldInfoPtr_alpha)) = value;
				}
			}

			// Token: 0x04009480 RID: 38016
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009481 RID: 38017
			private static readonly System.IntPtr NativeFieldInfoPtr_alpha;

			// Token: 0x04009482 RID: 38018
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009483 RID: 38019
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CCF RID: 3279
			[ObfuscatedName("ScheduleOne.UI.HintDisplay+<>c__DisplayClass24_0+<<SetAlpha>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EB05 RID: 60165 RVA: 0x00372F34 File Offset: 0x00371134
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique()
				{
					Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr, "<<SetAlpha>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr);
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>1__state");
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>2__current");
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>4__this");
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startAlpha_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<startAlpha>5__2");
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<i>5__3");
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681274);
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681275);
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681276);
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681277);
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681278);
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681279);
				}

				// Token: 0x0600EB06 RID: 60166 RVA: 0x0037303C File Offset: 0x0037123C
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EB07 RID: 60167 RVA: 0x00373084 File Offset: 0x00371284
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EB08 RID: 60168 RVA: 0x003730B8 File Offset: 0x003712B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261864, XrefRangeEnd = 261874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170048C4 RID: 18628
				// (get) Token: 0x0600EB09 RID: 60169 RVA: 0x003730F4 File Offset: 0x003712F4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EB0A RID: 60170 RVA: 0x00373134 File Offset: 0x00371334
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261874, XrefRangeEnd = 261879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170048C5 RID: 18629
				// (get) Token: 0x0600EB0B RID: 60171 RVA: 0x00373168 File Offset: 0x00371368
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EB0C RID: 60172 RVA: 0x00072511 File Offset: 0x00070711
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170048BF RID: 18623
				// (get) Token: 0x0600EB0D RID: 60173 RVA: 0x003731A8 File Offset: 0x003713A8
				// (set) Token: 0x0600EB0E RID: 60174 RVA: 0x0007251A File Offset: 0x0007071A
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170048C0 RID: 18624
				// (get) Token: 0x0600EB0F RID: 60175 RVA: 0x003731D0 File Offset: 0x003713D0
				// (set) Token: 0x0600EB10 RID: 60176 RVA: 0x00072535 File Offset: 0x00070735
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048C1 RID: 18625
				// (get) Token: 0x0600EB11 RID: 60177 RVA: 0x00373200 File Offset: 0x00371400
				// (set) Token: 0x0600EB12 RID: 60178 RVA: 0x00072554 File Offset: 0x00070754
				public unsafe HintDisplay.__c__DisplayClass24_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<HintDisplay.__c__DisplayClass24_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048C2 RID: 18626
				// (get) Token: 0x0600EB13 RID: 60179 RVA: 0x00373230 File Offset: 0x00371430
				// (set) Token: 0x0600EB14 RID: 60180 RVA: 0x00072573 File Offset: 0x00070773
				public unsafe float _startAlpha_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startAlpha_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startAlpha_5__2)) = value;
					}
				}

				// Token: 0x170048C3 RID: 18627
				// (get) Token: 0x0600EB15 RID: 60181 RVA: 0x00373258 File Offset: 0x00371458
				// (set) Token: 0x0600EB16 RID: 60182 RVA: 0x0007258E File Offset: 0x0007078E
				public unsafe float _i_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x04009D32 RID: 40242
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009D33 RID: 40243
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009D34 RID: 40244
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009D35 RID: 40245
				private static readonly System.IntPtr NativeFieldInfoPtr__startAlpha_5__2;

				// Token: 0x04009D36 RID: 40246
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x04009D37 RID: 40247
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009D38 RID: 40248
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D39 RID: 40249
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009D3A RID: 40250
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009D3B RID: 40251
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D3C RID: 40252
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
