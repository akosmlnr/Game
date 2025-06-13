using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000735 RID: 1845
	public class ShopAmountSelector : MonoBehaviour
	{
		// Token: 0x0600A4CD RID: 42189 RVA: 0x00298B34 File Offset: 0x00296D34
		// Note: this type is marked as 'beforefieldinit'.
		static ShopAmountSelector()
		{
			Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ShopAmountSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr);
			ShopAmountSelector.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, "<IsOpen>k__BackingField");
			ShopAmountSelector.NativeFieldInfoPtr__SelectedAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, "<SelectedAmount>k__BackingField");
			ShopAmountSelector.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, "Container");
			ShopAmountSelector.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, "InputField");
			ShopAmountSelector.NativeFieldInfoPtr_onSubmitted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, "onSubmitted");
			ShopAmountSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683544);
			ShopAmountSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683545);
			ShopAmountSelector.NativeMethodInfoPtr_get_SelectedAmount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683546);
			ShopAmountSelector.NativeMethodInfoPtr_set_SelectedAmount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683547);
			ShopAmountSelector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683548);
			ShopAmountSelector.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683549);
			ShopAmountSelector.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683550);
			ShopAmountSelector.NativeMethodInfoPtr_OnSubmitted_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683551);
			ShopAmountSelector.NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683552);
			ShopAmountSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683553);
		}

		// Token: 0x1700329C RID: 12956
		// (get) Token: 0x0600A4CE RID: 42190 RVA: 0x00298C90 File Offset: 0x00296E90
		// (set) Token: 0x0600A4CF RID: 42191 RVA: 0x00298CCC File Offset: 0x00296ECC
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700329D RID: 12957
		// (get) Token: 0x0600A4D0 RID: 42192 RVA: 0x00298D0C File Offset: 0x00296F0C
		// (set) Token: 0x0600A4D1 RID: 42193 RVA: 0x00298D48 File Offset: 0x00296F48
		public unsafe int SelectedAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_get_SelectedAmount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31397, RefRangeEnd = 31398, XrefRangeStart = 31397, XrefRangeEnd = 31398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_set_SelectedAmount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A4D2 RID: 42194 RVA: 0x00298D88 File Offset: 0x00296F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288958, XrefRangeEnd = 288977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A4D3 RID: 42195 RVA: 0x00298DBC File Offset: 0x00296FBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 288983, RefRangeEnd = 288986, XrefRangeStart = 288977, XrefRangeEnd = 288983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A4D4 RID: 42196 RVA: 0x00298DF0 File Offset: 0x00296FF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288988, RefRangeEnd = 288990, XrefRangeStart = 288986, XrefRangeEnd = 288988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A4D5 RID: 42197 RVA: 0x00298E24 File Offset: 0x00297024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288990, XrefRangeEnd = 289002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSubmitted(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_OnSubmitted_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A4D6 RID: 42198 RVA: 0x00298E68 File Offset: 0x00297068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289002, XrefRangeEnd = 289006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChanged(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A4D7 RID: 42199 RVA: 0x00298EAC File Offset: 0x002970AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289006, XrefRangeEnd = 289007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopAmountSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A4D8 RID: 42200 RVA: 0x00050DFA File Offset: 0x0004EFFA
		public ShopAmountSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003297 RID: 12951
		// (get) Token: 0x0600A4D9 RID: 42201 RVA: 0x00298EE8 File Offset: 0x002970E8
		// (set) Token: 0x0600A4DA RID: 42202 RVA: 0x00050E03 File Offset: 0x0004F003
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003298 RID: 12952
		// (get) Token: 0x0600A4DB RID: 42203 RVA: 0x00298F10 File Offset: 0x00297110
		// (set) Token: 0x0600A4DC RID: 42204 RVA: 0x00050E1E File Offset: 0x0004F01E
		public unsafe int _SelectedAmount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr__SelectedAmount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr__SelectedAmount_k__BackingField)) = value;
			}
		}

		// Token: 0x17003299 RID: 12953
		// (get) Token: 0x0600A4DD RID: 42205 RVA: 0x00298F38 File Offset: 0x00297138
		// (set) Token: 0x0600A4DE RID: 42206 RVA: 0x00050E39 File Offset: 0x0004F039
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700329A RID: 12954
		// (get) Token: 0x0600A4DF RID: 42207 RVA: 0x00298F68 File Offset: 0x00297168
		// (set) Token: 0x0600A4E0 RID: 42208 RVA: 0x00050E58 File Offset: 0x0004F058
		public unsafe TMP_InputField InputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_InputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700329B RID: 12955
		// (get) Token: 0x0600A4E1 RID: 42209 RVA: 0x00298F98 File Offset: 0x00297198
		// (set) Token: 0x0600A4E2 RID: 42210 RVA: 0x00050E77 File Offset: 0x0004F077
		public unsafe UnityEvent<int> onSubmitted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_onSubmitted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_onSubmitted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006E8E RID: 28302
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006E8F RID: 28303
		private static readonly IntPtr NativeFieldInfoPtr__SelectedAmount_k__BackingField;

		// Token: 0x04006E90 RID: 28304
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006E91 RID: 28305
		private static readonly IntPtr NativeFieldInfoPtr_InputField;

		// Token: 0x04006E92 RID: 28306
		private static readonly IntPtr NativeFieldInfoPtr_onSubmitted;

		// Token: 0x04006E93 RID: 28307
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006E94 RID: 28308
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04006E95 RID: 28309
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedAmount_Public_get_Int32_0;

		// Token: 0x04006E96 RID: 28310
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedAmount_Private_set_Void_Int32_0;

		// Token: 0x04006E97 RID: 28311
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006E98 RID: 28312
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04006E99 RID: 28313
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006E9A RID: 28314
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmitted_Private_Void_String_0;

		// Token: 0x04006E9B RID: 28315
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0;

		// Token: 0x04006E9C RID: 28316
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
