using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000668 RID: 1640
	public class ClothingSlotUI : ItemSlotUI
	{
		// Token: 0x06009047 RID: 36935 RVA: 0x0025AEDC File Offset: 0x002590DC
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingSlotUI()
		{
			Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ClothingSlotUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr);
			ClothingSlotUI.NativeFieldInfoPtr_SlotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr, "SlotType");
			ClothingSlotUI.NativeFieldInfoPtr_SlotTypeImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr, "SlotTypeImage");
			ClothingSlotUI.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr, 100681311);
			ClothingSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr, 100681312);
		}

		// Token: 0x06009048 RID: 36936 RVA: 0x0025AF5C File Offset: 0x0025915C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262404, XrefRangeEnd = 262411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingSlotUI.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009049 RID: 36937 RVA: 0x0025AF90 File Offset: 0x00259190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingSlotUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600904A RID: 36938 RVA: 0x00045150 File Offset: 0x00043350
		public ClothingSlotUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002BDA RID: 11226
		// (get) Token: 0x0600904B RID: 36939 RVA: 0x0025AFCC File Offset: 0x002591CC
		// (set) Token: 0x0600904C RID: 36940 RVA: 0x00045159 File Offset: 0x00043359
		public unsafe EClothingSlot SlotType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingSlotUI.NativeFieldInfoPtr_SlotType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingSlotUI.NativeFieldInfoPtr_SlotType)) = value;
			}
		}

		// Token: 0x17002BDB RID: 11227
		// (get) Token: 0x0600904D RID: 36941 RVA: 0x0025AFF4 File Offset: 0x002591F4
		// (set) Token: 0x0600904E RID: 36942 RVA: 0x00045174 File Offset: 0x00043374
		public unsafe Image SlotTypeImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingSlotUI.NativeFieldInfoPtr_SlotTypeImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingSlotUI.NativeFieldInfoPtr_SlotTypeImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040061BA RID: 25018
		private static readonly IntPtr NativeFieldInfoPtr_SlotType;

		// Token: 0x040061BB RID: 25019
		private static readonly IntPtr NativeFieldInfoPtr_SlotTypeImage;

		// Token: 0x040061BC RID: 25020
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040061BD RID: 25021
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
