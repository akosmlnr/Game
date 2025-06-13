using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x02000706 RID: 1798
	public class PotUIElement : WorldspaceUIElement
	{
		// Token: 0x0600A07C RID: 41084 RVA: 0x0028B4CC File Offset: 0x002896CC
		// Note: this type is marked as 'beforefieldinit'.
		static PotUIElement()
		{
			Il2CppClassPointerStore<PotUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "PotUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr);
			PotUIElement.NativeFieldInfoPtr_SeedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "SeedIcon");
			PotUIElement.NativeFieldInfoPtr_NoSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "NoSeed");
			PotUIElement.NativeFieldInfoPtr_Additive1Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "Additive1Icon");
			PotUIElement.NativeFieldInfoPtr_Additive2Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "Additive2Icon");
			PotUIElement.NativeFieldInfoPtr_Additive3Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "Additive3Icon");
			PotUIElement.NativeFieldInfoPtr__AssignedPot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "<AssignedPot>k__BackingField");
			PotUIElement.NativeMethodInfoPtr_get_AssignedPot_Public_get_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, 100683080);
			PotUIElement.NativeMethodInfoPtr_set_AssignedPot_Protected_set_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, 100683081);
			PotUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, 100683082);
			PotUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, 100683083);
			PotUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, 100683084);
		}

		// Token: 0x1700313E RID: 12606
		// (get) Token: 0x0600A07D RID: 41085 RVA: 0x0028B5D8 File Offset: 0x002897D8
		// (set) Token: 0x0600A07E RID: 41086 RVA: 0x0028B618 File Offset: 0x00289818
		public unsafe Pot AssignedPot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 48163, RefRangeEnd = 48164, XrefRangeStart = 48163, XrefRangeEnd = 48164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotUIElement.NativeMethodInfoPtr_get_AssignedPot_Public_get_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotUIElement.NativeMethodInfoPtr_set_AssignedPot_Protected_set_Void_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A07F RID: 41087 RVA: 0x0028B65C File Offset: 0x0028985C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284165, RefRangeEnd = 284166, XrefRangeStart = 284155, XrefRangeEnd = 284165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A080 RID: 41088 RVA: 0x0028B6A0 File Offset: 0x002898A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284166, XrefRangeEnd = 284206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A081 RID: 41089 RVA: 0x0028B6DC File Offset: 0x002898DC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A082 RID: 41090 RVA: 0x0004E7C0 File Offset: 0x0004C9C0
		public PotUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003138 RID: 12600
		// (get) Token: 0x0600A083 RID: 41091 RVA: 0x0028B718 File Offset: 0x00289918
		// (set) Token: 0x0600A084 RID: 41092 RVA: 0x0004E7C9 File Offset: 0x0004C9C9
		public unsafe Image SeedIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_SeedIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_SeedIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003139 RID: 12601
		// (get) Token: 0x0600A085 RID: 41093 RVA: 0x0028B748 File Offset: 0x00289948
		// (set) Token: 0x0600A086 RID: 41094 RVA: 0x0004E7E8 File Offset: 0x0004C9E8
		public unsafe GameObject NoSeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_NoSeed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_NoSeed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700313A RID: 12602
		// (get) Token: 0x0600A087 RID: 41095 RVA: 0x0028B778 File Offset: 0x00289978
		// (set) Token: 0x0600A088 RID: 41096 RVA: 0x0004E807 File Offset: 0x0004CA07
		public unsafe Image Additive1Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive1Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive1Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700313B RID: 12603
		// (get) Token: 0x0600A089 RID: 41097 RVA: 0x0028B7A8 File Offset: 0x002899A8
		// (set) Token: 0x0600A08A RID: 41098 RVA: 0x0004E826 File Offset: 0x0004CA26
		public unsafe Image Additive2Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive2Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive2Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700313C RID: 12604
		// (get) Token: 0x0600A08B RID: 41099 RVA: 0x0028B7D8 File Offset: 0x002899D8
		// (set) Token: 0x0600A08C RID: 41100 RVA: 0x0004E845 File Offset: 0x0004CA45
		public unsafe Image Additive3Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive3Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive3Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700313D RID: 12605
		// (get) Token: 0x0600A08D RID: 41101 RVA: 0x0028B808 File Offset: 0x00289A08
		// (set) Token: 0x0600A08E RID: 41102 RVA: 0x0004E864 File Offset: 0x0004CA64
		public unsafe Pot _AssignedPot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr__AssignedPot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr__AssignedPot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006BC4 RID: 27588
		private static readonly IntPtr NativeFieldInfoPtr_SeedIcon;

		// Token: 0x04006BC5 RID: 27589
		private static readonly IntPtr NativeFieldInfoPtr_NoSeed;

		// Token: 0x04006BC6 RID: 27590
		private static readonly IntPtr NativeFieldInfoPtr_Additive1Icon;

		// Token: 0x04006BC7 RID: 27591
		private static readonly IntPtr NativeFieldInfoPtr_Additive2Icon;

		// Token: 0x04006BC8 RID: 27592
		private static readonly IntPtr NativeFieldInfoPtr_Additive3Icon;

		// Token: 0x04006BC9 RID: 27593
		private static readonly IntPtr NativeFieldInfoPtr__AssignedPot_k__BackingField;

		// Token: 0x04006BCA RID: 27594
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedPot_Public_get_Pot_0;

		// Token: 0x04006BCB RID: 27595
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedPot_Protected_set_Void_Pot_0;

		// Token: 0x04006BCC RID: 27596
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Pot_0;

		// Token: 0x04006BCD RID: 27597
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04006BCE RID: 27598
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
