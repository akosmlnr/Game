using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000243 RID: 579
	public class PropertyLoader : Loader
	{
		// Token: 0x06002ECE RID: 11982 RVA: 0x00108688 File Offset: 0x00106888
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyLoader()
		{
			Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "PropertyLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr);
			PropertyLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr, 100668718);
			PropertyLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr, 100668719);
			PropertyLoader.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PropertyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr, 100668720);
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x001086F4 File Offset: 0x001068F4
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002ED0 RID: 11984 RVA: 0x00108730 File Offset: 0x00106930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131844, RefRangeEnd = 131845, XrefRangeStart = 131694, XrefRangeEnd = 131844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x00108780 File Offset: 0x00106980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131873, RefRangeEnd = 131874, XrefRangeStart = 131845, XrefRangeEnd = 131873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(PropertyData propertyData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyData);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyLoader.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PropertyData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x00018DF2 File Offset: 0x00016FF2
		public PropertyLoader(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F09 RID: 7945
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F0A RID: 7946
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001F0B RID: 7947
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PropertyData_0;

		// Token: 0x02000932 RID: 2354
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.PropertyLoader+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C9E2 RID: 51682 RVA: 0x003144F0 File Offset: 0x003126F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr);
				PropertyLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_objectPriorities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr, "objectPriorities");
				PropertyLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr, 100668721);
				PropertyLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__Load_b__0_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr, 100668722);
			}

			// Token: 0x0600C9E3 RID: 51683 RVA: 0x00314558 File Offset: 0x00312758
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C9E4 RID: 51684 RVA: 0x00314594 File Offset: 0x00312794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131690, XrefRangeEnd = 131694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Load_b__0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PropertyLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__Load_b__0_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C9E5 RID: 51685 RVA: 0x00061E42 File Offset: 0x00060042
			public __c__DisplayClass1_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EB4 RID: 16052
			// (get) Token: 0x0600C9E6 RID: 51686 RVA: 0x003145E4 File Offset: 0x003127E4
			// (set) Token: 0x0600C9E7 RID: 51687 RVA: 0x00061E4B File Offset: 0x0006004B
			public unsafe Dictionary<string, int> objectPriorities
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_objectPriorities);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_objectPriorities), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088F5 RID: 35061
			private static readonly System.IntPtr NativeFieldInfoPtr_objectPriorities;

			// Token: 0x040088F6 RID: 35062
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088F7 RID: 35063
			private static readonly System.IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Int32_String_0;
		}
	}
}
