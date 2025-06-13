using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003B2 RID: 946
	public class ConfigField : Il2CppSystem.Object
	{
		// Token: 0x0600493E RID: 18750 RVA: 0x001680D4 File Offset: 0x001662D4
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigField()
		{
			Il2CppClassPointerStore<ConfigField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ConfigField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigField>.NativeClassPtr);
			ConfigField.NativeFieldInfoPtr__ParentConfig_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigField>.NativeClassPtr, "<ParentConfig>k__BackingField");
			ConfigField.NativeMethodInfoPtr_get_ParentConfig_Public_get_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigField>.NativeClassPtr, 100672430);
			ConfigField.NativeMethodInfoPtr_set_ParentConfig_Protected_set_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigField>.NativeClassPtr, 100672431);
			ConfigField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigField>.NativeClassPtr, 100672432);
			ConfigField.NativeMethodInfoPtr_IsValueDefault_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigField>.NativeClassPtr, 100672433);
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x0600493F RID: 18751 RVA: 0x00168168 File Offset: 0x00166368
		// (set) Token: 0x06004940 RID: 18752 RVA: 0x001681A8 File Offset: 0x001663A8
		public unsafe EntityConfiguration ParentConfig
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 18697, RefRangeEnd = 18709, XrefRangeStart = 18697, XrefRangeEnd = 18709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigField.NativeMethodInfoPtr_get_ParentConfig_Public_get_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 31460, RefRangeEnd = 31462, XrefRangeStart = 31460, XrefRangeEnd = 31462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigField.NativeMethodInfoPtr_set_ParentConfig_Protected_set_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004941 RID: 18753 RVA: 0x001681EC File Offset: 0x001663EC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 165909, RefRangeEnd = 165917, XrefRangeStart = 165901, XrefRangeEnd = 165909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigField>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004942 RID: 18754 RVA: 0x00168238 File Offset: 0x00166438
		[CallerCount(0)]
		public unsafe virtual bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigField.NativeMethodInfoPtr_IsValueDefault_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004943 RID: 18755 RVA: 0x0002341E File Offset: 0x0002161E
		public ConfigField(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x06004944 RID: 18756 RVA: 0x00168280 File Offset: 0x00166480
		// (set) Token: 0x06004945 RID: 18757 RVA: 0x00023427 File Offset: 0x00021627
		public unsafe EntityConfiguration _ParentConfig_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigField.NativeFieldInfoPtr__ParentConfig_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigField.NativeFieldInfoPtr__ParentConfig_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003156 RID: 12630
		private static readonly System.IntPtr NativeFieldInfoPtr__ParentConfig_k__BackingField;

		// Token: 0x04003157 RID: 12631
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ParentConfig_Public_get_EntityConfiguration_0;

		// Token: 0x04003158 RID: 12632
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ParentConfig_Protected_set_Void_EntityConfiguration_0;

		// Token: 0x04003159 RID: 12633
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x0400315A RID: 12634
		private static readonly System.IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Abstract_Virtual_New_Boolean_0;
	}
}
