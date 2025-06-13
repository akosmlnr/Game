using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006FB RID: 1787
	public class BotanistUIElement : WorldspaceUIElement
	{
		// Token: 0x0600A005 RID: 40965 RVA: 0x00289B1C File Offset: 0x00287D1C
		// Note: this type is marked as 'beforefieldinit'.
		static BotanistUIElement()
		{
			Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "BotanistUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr);
			BotanistUIElement.NativeFieldInfoPtr_SupplyIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, "SupplyIcon");
			BotanistUIElement.NativeFieldInfoPtr_NoSupply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, "NoSupply");
			BotanistUIElement.NativeFieldInfoPtr_SupplyLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, "SupplyLabel");
			BotanistUIElement.NativeFieldInfoPtr_PotRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, "PotRects");
			BotanistUIElement.NativeFieldInfoPtr__AssignedBotanist_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, "<AssignedBotanist>k__BackingField");
			BotanistUIElement.NativeMethodInfoPtr_get_AssignedBotanist_Public_get_Botanist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, 100683025);
			BotanistUIElement.NativeMethodInfoPtr_set_AssignedBotanist_Protected_set_Void_Botanist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, 100683026);
			BotanistUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Botanist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, 100683027);
			BotanistUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, 100683028);
			BotanistUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, 100683029);
		}

		// Token: 0x1700311D RID: 12573
		// (get) Token: 0x0600A006 RID: 40966 RVA: 0x00289C14 File Offset: 0x00287E14
		// (set) Token: 0x0600A007 RID: 40967 RVA: 0x00289C54 File Offset: 0x00287E54
		public unsafe Botanist AssignedBotanist
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24376, RefRangeEnd = 24377, XrefRangeStart = 24376, XrefRangeEnd = 24377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistUIElement.NativeMethodInfoPtr_get_AssignedBotanist_Public_get_Botanist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistUIElement.NativeMethodInfoPtr_set_AssignedBotanist_Protected_set_Void_Botanist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A008 RID: 40968 RVA: 0x00289C98 File Offset: 0x00287E98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283907, RefRangeEnd = 283908, XrefRangeStart = 283896, XrefRangeEnd = 283907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Botanist bot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bot);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Botanist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A009 RID: 40969 RVA: 0x00289CDC File Offset: 0x00287EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283908, XrefRangeEnd = 283944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A00A RID: 40970 RVA: 0x00289D18 File Offset: 0x00287F18
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BotanistUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A00B RID: 40971 RVA: 0x0004E4D2 File Offset: 0x0004C6D2
		public BotanistUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003118 RID: 12568
		// (get) Token: 0x0600A00C RID: 40972 RVA: 0x00289D54 File Offset: 0x00287F54
		// (set) Token: 0x0600A00D RID: 40973 RVA: 0x0004E4DB File Offset: 0x0004C6DB
		public unsafe Image SupplyIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_SupplyIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_SupplyIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003119 RID: 12569
		// (get) Token: 0x0600A00E RID: 40974 RVA: 0x00289D84 File Offset: 0x00287F84
		// (set) Token: 0x0600A00F RID: 40975 RVA: 0x0004E4FA File Offset: 0x0004C6FA
		public unsafe GameObject NoSupply
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_NoSupply);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_NoSupply), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700311A RID: 12570
		// (get) Token: 0x0600A010 RID: 40976 RVA: 0x00289DB4 File Offset: 0x00287FB4
		// (set) Token: 0x0600A011 RID: 40977 RVA: 0x0004E519 File Offset: 0x0004C719
		public unsafe TextMeshProUGUI SupplyLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_SupplyLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_SupplyLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700311B RID: 12571
		// (get) Token: 0x0600A012 RID: 40978 RVA: 0x00289DE4 File Offset: 0x00287FE4
		// (set) Token: 0x0600A013 RID: 40979 RVA: 0x0004E538 File Offset: 0x0004C738
		public unsafe Il2CppReferenceArray<RectTransform> PotRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_PotRects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_PotRects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700311C RID: 12572
		// (get) Token: 0x0600A014 RID: 40980 RVA: 0x00289E14 File Offset: 0x00288014
		// (set) Token: 0x0600A015 RID: 40981 RVA: 0x0004E557 File Offset: 0x0004C757
		public unsafe Botanist _AssignedBotanist_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr__AssignedBotanist_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr__AssignedBotanist_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006B78 RID: 27512
		private static readonly IntPtr NativeFieldInfoPtr_SupplyIcon;

		// Token: 0x04006B79 RID: 27513
		private static readonly IntPtr NativeFieldInfoPtr_NoSupply;

		// Token: 0x04006B7A RID: 27514
		private static readonly IntPtr NativeFieldInfoPtr_SupplyLabel;

		// Token: 0x04006B7B RID: 27515
		private static readonly IntPtr NativeFieldInfoPtr_PotRects;

		// Token: 0x04006B7C RID: 27516
		private static readonly IntPtr NativeFieldInfoPtr__AssignedBotanist_k__BackingField;

		// Token: 0x04006B7D RID: 27517
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedBotanist_Public_get_Botanist_0;

		// Token: 0x04006B7E RID: 27518
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedBotanist_Protected_set_Void_Botanist_0;

		// Token: 0x04006B7F RID: 27519
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Botanist_0;

		// Token: 0x04006B80 RID: 27520
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04006B81 RID: 27521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
