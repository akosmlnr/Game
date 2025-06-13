using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000235 RID: 565
	public class DeliveriesLoader : Loader
	{
		// Token: 0x06002E8A RID: 11914 RVA: 0x001074D8 File Offset: 0x001056D8
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveriesLoader()
		{
			Il2CppClassPointerStore<DeliveriesLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "DeliveriesLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveriesLoader>.NativeClassPtr);
			DeliveriesLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveriesLoader>.NativeClassPtr, 100668669);
			DeliveriesLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveriesLoader>.NativeClassPtr, 100668670);
			DeliveriesLoader.NativeMethodInfoPtr_LoadVehicle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveriesLoader>.NativeClassPtr, 100668671);
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x00107544 File Offset: 0x00105744
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveriesLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveriesLoader>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveriesLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x00107580 File Offset: 0x00105780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131011, XrefRangeEnd = 131060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveriesLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x001075D0 File Offset: 0x001057D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131097, RefRangeEnd = 131098, XrefRangeStart = 131060, XrefRangeEnd = 131097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadVehicle(string vehiclePath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(vehiclePath);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveriesLoader.NativeMethodInfoPtr_LoadVehicle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x00018D74 File Offset: 0x00016F74
		public DeliveriesLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001EE1 RID: 7905
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EE2 RID: 7906
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001EE3 RID: 7907
		private static readonly IntPtr NativeMethodInfoPtr_LoadVehicle_Public_Void_String_0;
	}
}
