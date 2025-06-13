using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005F3 RID: 1523
	[Serializable]
	public class BuildableItemDefinition : StorableItemDefinition
	{
		// Token: 0x06008536 RID: 34102 RVA: 0x00238ED8 File Offset: 0x002370D8
		// Note: this type is marked as 'beforefieldinit'.
		static BuildableItemDefinition()
		{
			Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "BuildableItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr);
			BuildableItemDefinition.NativeFieldInfoPtr_BuiltItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr, "BuiltItem");
			BuildableItemDefinition.NativeFieldInfoPtr_BuildSoundType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr, "BuildSoundType");
			BuildableItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr, 100680061);
		}

		// Token: 0x06008537 RID: 34103 RVA: 0x00238F44 File Offset: 0x00237144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008538 RID: 34104 RVA: 0x0003F0EF File Offset: 0x0003D2EF
		public BuildableItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002820 RID: 10272
		// (get) Token: 0x06008539 RID: 34105 RVA: 0x00238F80 File Offset: 0x00237180
		// (set) Token: 0x0600853A RID: 34106 RVA: 0x0003F0F8 File Offset: 0x0003D2F8
		public unsafe BuildableItem BuiltItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemDefinition.NativeFieldInfoPtr_BuiltItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemDefinition.NativeFieldInfoPtr_BuiltItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002821 RID: 10273
		// (get) Token: 0x0600853B RID: 34107 RVA: 0x00238FB0 File Offset: 0x002371B0
		// (set) Token: 0x0600853C RID: 34108 RVA: 0x0003F117 File Offset: 0x0003D317
		public unsafe BuildableItemDefinition.EBuildSoundType BuildSoundType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemDefinition.NativeFieldInfoPtr_BuildSoundType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemDefinition.NativeFieldInfoPtr_BuildSoundType)) = value;
			}
		}

		// Token: 0x04005AAC RID: 23212
		private static readonly IntPtr NativeFieldInfoPtr_BuiltItem;

		// Token: 0x04005AAD RID: 23213
		private static readonly IntPtr NativeFieldInfoPtr_BuildSoundType;

		// Token: 0x04005AAE RID: 23214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B33 RID: 2867
		[OriginalName("Assembly-CSharp.dll", "", "EBuildSoundType")]
		public enum EBuildSoundType
		{
			// Token: 0x040092FE RID: 37630
			Cardboard,
			// Token: 0x040092FF RID: 37631
			Wood,
			// Token: 0x04009300 RID: 37632
			Metal
		}
	}
}
