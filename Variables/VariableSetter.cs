using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x0200018F RID: 399
	[System.Serializable]
	public class VariableSetter : Il2CppSystem.Object
	{
		// Token: 0x06001F7F RID: 8063 RVA: 0x000D5D94 File Offset: 0x000D3F94
		// Note: this type is marked as 'beforefieldinit'.
		static VariableSetter()
		{
			Il2CppClassPointerStore<VariableSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "VariableSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr);
			VariableSetter.NativeFieldInfoPtr_VariableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr, "VariableName");
			VariableSetter.NativeFieldInfoPtr_NewValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr, "NewValue");
			VariableSetter.NativeMethodInfoPtr_Execute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr, 100666899);
			VariableSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr, 100666900);
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x000D5E14 File Offset: 0x000D4014
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111618, RefRangeEnd = 111619, XrefRangeStart = 111613, XrefRangeEnd = 111618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableSetter.NativeMethodInfoPtr_Execute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x000D5E48 File Offset: 0x000D4048
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VariableSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x00011948 File Offset: 0x0000FB48
		public VariableSetter(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x000D5E84 File Offset: 0x000D4084
		// (set) Token: 0x06001F84 RID: 8068 RVA: 0x00011951 File Offset: 0x0000FB51
		public unsafe string VariableName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VariableSetter.NativeFieldInfoPtr_VariableName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VariableSetter.NativeFieldInfoPtr_VariableName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06001F85 RID: 8069 RVA: 0x000D5EAC File Offset: 0x000D40AC
		// (set) Token: 0x06001F86 RID: 8070 RVA: 0x00011970 File Offset: 0x0000FB70
		public unsafe string NewValue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VariableSetter.NativeFieldInfoPtr_NewValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VariableSetter.NativeFieldInfoPtr_NewValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040014F1 RID: 5361
		private static readonly System.IntPtr NativeFieldInfoPtr_VariableName;

		// Token: 0x040014F2 RID: 5362
		private static readonly System.IntPtr NativeFieldInfoPtr_NewValue;

		// Token: 0x040014F3 RID: 5363
		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_0;

		// Token: 0x040014F4 RID: 5364
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
