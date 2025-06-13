using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x0200073F RID: 1855
	public class ItemDefinitionInfoHoverable : MonoBehaviour
	{
		// Token: 0x0600A639 RID: 42553 RVA: 0x0029D4E0 File Offset: 0x0029B6E0
		// Note: this type is marked as 'beforefieldinit'.
		static ItemDefinitionInfoHoverable()
		{
			Il2CppClassPointerStore<ItemDefinitionInfoHoverable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemDefinitionInfoHoverable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemDefinitionInfoHoverable>.NativeClassPtr);
			ItemDefinitionInfoHoverable.NativeFieldInfoPtr_AssignedItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinitionInfoHoverable>.NativeClassPtr, "AssignedItem");
			ItemDefinitionInfoHoverable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDefinitionInfoHoverable>.NativeClassPtr, 100683743);
		}

		// Token: 0x0600A63A RID: 42554 RVA: 0x0029D538 File Offset: 0x0029B738
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemDefinitionInfoHoverable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemDefinitionInfoHoverable>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemDefinitionInfoHoverable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A63B RID: 42555 RVA: 0x000519ED File Offset: 0x0004FBED
		public ItemDefinitionInfoHoverable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700330F RID: 13071
		// (get) Token: 0x0600A63C RID: 42556 RVA: 0x0029D574 File Offset: 0x0029B774
		// (set) Token: 0x0600A63D RID: 42557 RVA: 0x000519F6 File Offset: 0x0004FBF6
		public unsafe ItemDefinition AssignedItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinitionInfoHoverable.NativeFieldInfoPtr_AssignedItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinitionInfoHoverable.NativeFieldInfoPtr_AssignedItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006F82 RID: 28546
		private static readonly IntPtr NativeFieldInfoPtr_AssignedItem;

		// Token: 0x04006F83 RID: 28547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
