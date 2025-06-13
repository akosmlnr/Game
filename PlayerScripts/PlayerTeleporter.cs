using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x0200040A RID: 1034
	public class PlayerTeleporter : MonoBehaviour
	{
		// Token: 0x060053AC RID: 21420 RVA: 0x0018DE0C File Offset: 0x0018C00C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerTeleporter()
		{
			Il2CppClassPointerStore<PlayerTeleporter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerTeleporter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTeleporter>.NativeClassPtr);
			PlayerTeleporter.NativeMethodInfoPtr_Teleport_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleporter>.NativeClassPtr, 100673857);
			PlayerTeleporter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleporter>.NativeClassPtr, 100673858);
		}

		// Token: 0x060053AD RID: 21421 RVA: 0x0018DE64 File Offset: 0x0018C064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181719, XrefRangeEnd = 181738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Teleport(Transform destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTeleporter.NativeMethodInfoPtr_Teleport_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053AE RID: 21422 RVA: 0x0018DEA8 File Offset: 0x0018C0A8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerTeleporter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTeleporter>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTeleporter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053AF RID: 21423 RVA: 0x00027A32 File Offset: 0x00025C32
		public PlayerTeleporter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040038BE RID: 14526
		private static readonly IntPtr NativeMethodInfoPtr_Teleport_Public_Void_Transform_0;

		// Token: 0x040038BF RID: 14527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
