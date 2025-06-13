using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.EntityFramework
{
	// Token: 0x0200041F RID: 1055
	public class IProceduralTileContainer : Il2CppObjectBase
	{
		// Token: 0x06005741 RID: 22337 RVA: 0x00029966 File Offset: 0x00027B66
		// Note: this type is marked as 'beforefieldinit'.
		static IProceduralTileContainer()
		{
			Il2CppClassPointerStore<IProceduralTileContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.EntityFramework", "IProceduralTileContainer");
			IProceduralTileContainer.NativeMethodInfoPtr_get_ProceduralTiles_Public_Abstract_Virtual_New_get_List_1_ProceduralTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IProceduralTileContainer>.NativeClassPtr, 100674265);
		}

		// Token: 0x17001A3C RID: 6716
		// (get) Token: 0x06005742 RID: 22338 RVA: 0x001997A8 File Offset: 0x001979A8
		public unsafe virtual List<ProceduralTile> ProceduralTiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IProceduralTileContainer.NativeMethodInfoPtr_get_ProceduralTiles_Public_Abstract_Virtual_New_get_List_1_ProceduralTile_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProceduralTile>>(intPtr2) : null;
			}
		}

		// Token: 0x06005743 RID: 22339 RVA: 0x00029995 File Offset: 0x00027B95
		public IProceduralTileContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003B1C RID: 15132
		private static readonly IntPtr NativeMethodInfoPtr_get_ProceduralTiles_Public_Abstract_Virtual_New_get_List_1_ProceduralTile_0;
	}
}
