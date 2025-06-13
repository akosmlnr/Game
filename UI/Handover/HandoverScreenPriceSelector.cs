using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Handover
{
	// Token: 0x0200071D RID: 1821
	public class HandoverScreenPriceSelector : MonoBehaviour
	{
		// Token: 0x0600A23C RID: 41532 RVA: 0x002907AC File Offset: 0x0028E9AC
		// Note: this type is marked as 'beforefieldinit'.
		static HandoverScreenPriceSelector()
		{
			Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Handover", "HandoverScreenPriceSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr);
			HandoverScreenPriceSelector.NativeFieldInfoPtr_MinPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, "MinPrice");
			HandoverScreenPriceSelector.NativeFieldInfoPtr_MaxPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, "MaxPrice");
			HandoverScreenPriceSelector.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, "InputField");
			HandoverScreenPriceSelector.NativeFieldInfoPtr__Price_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, "<Price>k__BackingField");
			HandoverScreenPriceSelector.NativeFieldInfoPtr_onPriceChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, "onPriceChanged");
			HandoverScreenPriceSelector.NativeMethodInfoPtr_get_Price_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, 100683248);
			HandoverScreenPriceSelector.NativeMethodInfoPtr_set_Price_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, 100683249);
			HandoverScreenPriceSelector.NativeMethodInfoPtr_SetPrice_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, 100683250);
			HandoverScreenPriceSelector.NativeMethodInfoPtr_RefreshPrice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, 100683251);
			HandoverScreenPriceSelector.NativeMethodInfoPtr_OnPriceInputChanged_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, 100683252);
			HandoverScreenPriceSelector.NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, 100683253);
			HandoverScreenPriceSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, 100683254);
		}

		// Token: 0x170031CC RID: 12748
		// (get) Token: 0x0600A23D RID: 41533 RVA: 0x002908CC File Offset: 0x0028EACC
		// (set) Token: 0x0600A23E RID: 41534 RVA: 0x00290908 File Offset: 0x0028EB08
		public unsafe float Price
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 62417, RefRangeEnd = 62418, XrefRangeStart = 62417, XrefRangeEnd = 62418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HandoverScreenPriceSelector.NativeMethodInfoPtr_get_Price_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenPriceSelector.NativeMethodInfoPtr_set_Price_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A23F RID: 41535 RVA: 0x00290948 File Offset: 0x0028EB48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286167, RefRangeEnd = 286169, XrefRangeStart = 286164, XrefRangeEnd = 286167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPrice(float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref price;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenPriceSelector.NativeMethodInfoPtr_SetPrice_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A240 RID: 41536 RVA: 0x00290988 File Offset: 0x0028EB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286169, XrefRangeEnd = 286172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenPriceSelector.NativeMethodInfoPtr_RefreshPrice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A241 RID: 41537 RVA: 0x002909BC File Offset: 0x0028EBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286172, XrefRangeEnd = 286175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPriceInputChanged(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenPriceSelector.NativeMethodInfoPtr_OnPriceInputChanged_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A242 RID: 41538 RVA: 0x00290A00 File Offset: 0x0028EC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286175, XrefRangeEnd = 286176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeAmount(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenPriceSelector.NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A243 RID: 41539 RVA: 0x00290A40 File Offset: 0x0028EC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandoverScreenPriceSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenPriceSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A244 RID: 41540 RVA: 0x0004F7BB File Offset: 0x0004D9BB
		public HandoverScreenPriceSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031C7 RID: 12743
		// (get) Token: 0x0600A245 RID: 41541 RVA: 0x00290A7C File Offset: 0x0028EC7C
		// (set) Token: 0x0600A246 RID: 41542 RVA: 0x0004F7C4 File Offset: 0x0004D9C4
		public unsafe static float MinPrice
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(HandoverScreenPriceSelector.NativeFieldInfoPtr_MinPrice, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HandoverScreenPriceSelector.NativeFieldInfoPtr_MinPrice, (void*)(&value));
			}
		}

		// Token: 0x170031C8 RID: 12744
		// (get) Token: 0x0600A247 RID: 41543 RVA: 0x00290A98 File Offset: 0x0028EC98
		// (set) Token: 0x0600A248 RID: 41544 RVA: 0x0004F7D2 File Offset: 0x0004D9D2
		public unsafe static float MaxPrice
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(HandoverScreenPriceSelector.NativeFieldInfoPtr_MaxPrice, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HandoverScreenPriceSelector.NativeFieldInfoPtr_MaxPrice, (void*)(&value));
			}
		}

		// Token: 0x170031C9 RID: 12745
		// (get) Token: 0x0600A249 RID: 41545 RVA: 0x00290AB4 File Offset: 0x0028ECB4
		// (set) Token: 0x0600A24A RID: 41546 RVA: 0x0004F7E0 File Offset: 0x0004D9E0
		public unsafe InputField InputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenPriceSelector.NativeFieldInfoPtr_InputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenPriceSelector.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031CA RID: 12746
		// (get) Token: 0x0600A24B RID: 41547 RVA: 0x00290AE4 File Offset: 0x0028ECE4
		// (set) Token: 0x0600A24C RID: 41548 RVA: 0x0004F7FF File Offset: 0x0004D9FF
		public unsafe float _Price_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenPriceSelector.NativeFieldInfoPtr__Price_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenPriceSelector.NativeFieldInfoPtr__Price_k__BackingField)) = value;
			}
		}

		// Token: 0x170031CB RID: 12747
		// (get) Token: 0x0600A24D RID: 41549 RVA: 0x00290B0C File Offset: 0x0028ED0C
		// (set) Token: 0x0600A24E RID: 41550 RVA: 0x0004F81A File Offset: 0x0004DA1A
		public unsafe UnityEvent onPriceChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenPriceSelector.NativeFieldInfoPtr_onPriceChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenPriceSelector.NativeFieldInfoPtr_onPriceChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006CD2 RID: 27858
		private static readonly IntPtr NativeFieldInfoPtr_MinPrice;

		// Token: 0x04006CD3 RID: 27859
		private static readonly IntPtr NativeFieldInfoPtr_MaxPrice;

		// Token: 0x04006CD4 RID: 27860
		private static readonly IntPtr NativeFieldInfoPtr_InputField;

		// Token: 0x04006CD5 RID: 27861
		private static readonly IntPtr NativeFieldInfoPtr__Price_k__BackingField;

		// Token: 0x04006CD6 RID: 27862
		private static readonly IntPtr NativeFieldInfoPtr_onPriceChanged;

		// Token: 0x04006CD7 RID: 27863
		private static readonly IntPtr NativeMethodInfoPtr_get_Price_Public_get_Single_0;

		// Token: 0x04006CD8 RID: 27864
		private static readonly IntPtr NativeMethodInfoPtr_set_Price_Private_set_Void_Single_0;

		// Token: 0x04006CD9 RID: 27865
		private static readonly IntPtr NativeMethodInfoPtr_SetPrice_Public_Void_Single_0;

		// Token: 0x04006CDA RID: 27866
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPrice_Public_Void_0;

		// Token: 0x04006CDB RID: 27867
		private static readonly IntPtr NativeMethodInfoPtr_OnPriceInputChanged_Public_Void_String_0;

		// Token: 0x04006CDC RID: 27868
		private static readonly IntPtr NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0;

		// Token: 0x04006CDD RID: 27869
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
