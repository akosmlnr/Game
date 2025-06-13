using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x0200023E RID: 574
	public class NPCsLoader : Loader
	{
		// Token: 0x06002EB7 RID: 11959 RVA: 0x0010810C File Offset: 0x0010630C
		// Note: this type is marked as 'beforefieldinit'.
		static NPCsLoader()
		{
			Il2CppClassPointerStore<NPCsLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "NPCsLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCsLoader>.NativeClassPtr);
			NPCsLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCsLoader>.NativeClassPtr, 100668696);
			NPCsLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCsLoader>.NativeClassPtr, 100668697);
			NPCsLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCsLoader>.NativeClassPtr, 100668698);
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06002EB8 RID: 11960 RVA: 0x00108178 File Offset: 0x00106378
		public unsafe virtual string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131375, XrefRangeEnd = 131382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCsLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x06002EB9 RID: 11961 RVA: 0x001081BC File Offset: 0x001063BC
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCsLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCsLoader>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCsLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002EBA RID: 11962 RVA: 0x001081F8 File Offset: 0x001063F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131382, XrefRangeEnd = 131404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCsLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002EBB RID: 11963 RVA: 0x00018DC5 File Offset: 0x00016FC5
		public NPCsLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001EFC RID: 7932
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_New_get_String_0;

		// Token: 0x04001EFD RID: 7933
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EFE RID: 7934
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}
