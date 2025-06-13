using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Clothing
{
	// Token: 0x020004BB RID: 1211
	[Serializable]
	public class ClothingDefinition : StorableItemDefinition
	{
		// Token: 0x06006827 RID: 26663 RVA: 0x001D6A60 File Offset: 0x001D4C60
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingDefinition()
		{
			Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Clothing", "ClothingDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr);
			ClothingDefinition.NativeFieldInfoPtr_Slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "Slot");
			ClothingDefinition.NativeFieldInfoPtr_ApplicationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "ApplicationType");
			ClothingDefinition.NativeFieldInfoPtr_ClothingAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "ClothingAssetPath");
			ClothingDefinition.NativeFieldInfoPtr_Colorable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "Colorable");
			ClothingDefinition.NativeFieldInfoPtr_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "DefaultColor");
			ClothingDefinition.NativeFieldInfoPtr_SlotsToBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "SlotsToBlock");
			ClothingDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, 100676557);
			ClothingDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, 100676558);
		}

		// Token: 0x06006828 RID: 26664 RVA: 0x001D6B30 File Offset: 0x001D4D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211186, XrefRangeEnd = 211190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x06006829 RID: 26665 RVA: 0x001D6B88 File Offset: 0x001D4D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211190, XrefRangeEnd = 211202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600682A RID: 26666 RVA: 0x00031073 File Offset: 0x0002F273
		public ClothingDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F2A RID: 7978
		// (get) Token: 0x0600682B RID: 26667 RVA: 0x001D6BC4 File Offset: 0x001D4DC4
		// (set) Token: 0x0600682C RID: 26668 RVA: 0x0003107C File Offset: 0x0002F27C
		public unsafe EClothingSlot Slot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_Slot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_Slot)) = value;
			}
		}

		// Token: 0x17001F2B RID: 7979
		// (get) Token: 0x0600682D RID: 26669 RVA: 0x001D6BEC File Offset: 0x001D4DEC
		// (set) Token: 0x0600682E RID: 26670 RVA: 0x00031097 File Offset: 0x0002F297
		public unsafe EClothingApplicationType ApplicationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_ApplicationType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_ApplicationType)) = value;
			}
		}

		// Token: 0x17001F2C RID: 7980
		// (get) Token: 0x0600682F RID: 26671 RVA: 0x001D6C14 File Offset: 0x001D4E14
		// (set) Token: 0x06006830 RID: 26672 RVA: 0x000310B2 File Offset: 0x0002F2B2
		public unsafe string ClothingAssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_ClothingAssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_ClothingAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F2D RID: 7981
		// (get) Token: 0x06006831 RID: 26673 RVA: 0x001D6C3C File Offset: 0x001D4E3C
		// (set) Token: 0x06006832 RID: 26674 RVA: 0x000310D1 File Offset: 0x0002F2D1
		public unsafe bool Colorable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_Colorable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_Colorable)) = value;
			}
		}

		// Token: 0x17001F2E RID: 7982
		// (get) Token: 0x06006833 RID: 26675 RVA: 0x001D6C64 File Offset: 0x001D4E64
		// (set) Token: 0x06006834 RID: 26676 RVA: 0x000310EC File Offset: 0x0002F2EC
		public unsafe EClothingColor DefaultColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_DefaultColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_DefaultColor)) = value;
			}
		}

		// Token: 0x17001F2F RID: 7983
		// (get) Token: 0x06006835 RID: 26677 RVA: 0x001D6C8C File Offset: 0x001D4E8C
		// (set) Token: 0x06006836 RID: 26678 RVA: 0x00031107 File Offset: 0x0002F307
		public unsafe List<EClothingSlot> SlotsToBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_SlotsToBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EClothingSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_SlotsToBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004718 RID: 18200
		private static readonly IntPtr NativeFieldInfoPtr_Slot;

		// Token: 0x04004719 RID: 18201
		private static readonly IntPtr NativeFieldInfoPtr_ApplicationType;

		// Token: 0x0400471A RID: 18202
		private static readonly IntPtr NativeFieldInfoPtr_ClothingAssetPath;

		// Token: 0x0400471B RID: 18203
		private static readonly IntPtr NativeFieldInfoPtr_Colorable;

		// Token: 0x0400471C RID: 18204
		private static readonly IntPtr NativeFieldInfoPtr_DefaultColor;

		// Token: 0x0400471D RID: 18205
		private static readonly IntPtr NativeFieldInfoPtr_SlotsToBlock;

		// Token: 0x0400471E RID: 18206
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x0400471F RID: 18207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
